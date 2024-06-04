using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Drawing;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;

namespace View.PDFGenerator
{
    public class GeneratePDF
    {
        private double topMargin = 0;
        private double leftMargin = 0;
        private double rightMargin = 0;
        private double bottomMargin = 0;
        private double cm;

        private PdfDocument document;
        private PdfPage page;
        private XGraphics gfx;
        private XFont font;
        private XPen pen;
        private String outputPath;
        private double tableHight;

        public GeneratePDF(string argOutputpath,  bool argAddMarginGuides = false)
        {
            this.outputPath = argOutputpath;
            this.document = new PdfDocument();
            this.page = document.AddPage();
            this.page.Size = PdfSharp.PageSize.Letter;

            this.cm = new Interpolation().LinearInterpolation(0, 0, 27.9, page.Height, 1);
            Console.WriteLine("1 cm: " + cm);

            this.gfx = XGraphics.FromPdfPage(page);

            this.font = new XFont("Arial", 12, XFontStyle.Bold);
            this.pen = new XPen(XColors.Black, 0.5);

            topMargin = 2.5 * cm;
            leftMargin = 3 * cm;
            rightMargin = page.Width - (3 * cm);
            bottomMargin = page.Height - (2.5 * cm);
        }
        public void DrawTable(double initialPosX, double initialPosY, double width, double height, List<String[]> contents, List<StavkaPorudzbine> pzr, List<Proizvod> proizvodiLista)
        {
            if (contents == null)
            {
                contents = new List<String[]>();

                contents.Add(new string[] { "Naziv proizvoda", "Jedinicna cena", "Kolicina", "Cena" });

                for (int i = 0; i < pzr.Count; i++)
                {
                    for (int y = 0; y < proizvodiLista.Count; y++)
                    {
                        if (pzr[i].Proizvod.ProizvodID == proizvodiLista[y].ProizvodID)
                        {
                            contents.Add(new String[] { proizvodiLista[y].NazivProizvoda, proizvodiLista[y].ProdajnaCena.ToString(), pzr[i].Kolicina.ToString(), pzr[i].Cena.ToString() });
                        }
                    }
                }

            }

            int columns = contents[0].Length;
            int rows = contents.Count;

            double distanceBetweenRows = 1.0;
            double distanceBetweenColumns = width / columns;

            DPoint pointA = new DPoint(initialPosX, initialPosY);

            pointA = new DPoint(initialPosX, initialPosY);

            foreach (string[] rowDataArray in contents)
            {
                for (int i = 0; i < rowDataArray.Length; i++)
                {
                    string cellText = rowDataArray[i];
                    XStringFormat format = XStringFormats.Center;

                    if (i == 0) 
                    {
                        format = XStringFormats.CenterLeft;
                    }
                    else if (i >0) 
                    {
                        format = XStringFormats.CenterRight;
                    }

                    this.gfx.DrawString(cellText, this.font, XBrushes.Black, new XRect(leftMargin + (pointA.x * cm), topMargin + (pointA.y * cm), distanceBetweenColumns * cm, distanceBetweenRows * cm), format);

                    pointA.x = pointA.x + distanceBetweenColumns;
                }

                pointA.x = initialPosX;
                pointA.y = pointA.y + distanceBetweenRows;

                this.tableHight = rows * distanceBetweenRows;
            }
        }
        public double getTableHight()
        {
            return this.tableHight;
        }
        public void AddText(string text, DPoint xyStartingPosition, int size = 12)
        {
            this.gfx.DrawString(text, this.font, XBrushes.Black, leftMargin + (xyStartingPosition.x * cm), topMargin + (xyStartingPosition.y * cm));
        }
        public void DrawSquare(DPoint xyStartingPosition, double width, double height, XBrush xbrush)
        {
            this.gfx.DrawRectangle(xbrush, new XRect(leftMargin + (xyStartingPosition.x * cm), topMargin + (xyStartingPosition.y * cm), (width * cm), (height * cm)));
        }
        public void DrawLine(DPoint fromXyPosition, DPoint toXyPosition)
        {
            this.gfx.DrawLine(this.pen, leftMargin + (fromXyPosition.x * cm), topMargin + (fromXyPosition.y * cm), leftMargin + (toXyPosition.x * cm), topMargin + (toXyPosition.y * cm));
        }
        public void SaveAndShow(bool argShowAfterSaving = true)
        {
            document.Save(this.outputPath);

            if (argShowAfterSaving)
            {
                System.Diagnostics.Process.Start(this.outputPath);
            }
        }
        public void AddQRCode(string text, double sizeInCm, double v)
        {
            XImage qrCodeImage = CreateQRCode(text);

            double qrCodeWidth = sizeInCm * cm;
            double qrCodeHeight = sizeInCm * cm;
            double centerX = (page.Width - qrCodeWidth) / 2;
            double centerY = topMargin + (v * cm);

            this.gfx.DrawImage(qrCodeImage, centerX, centerY, qrCodeWidth, qrCodeHeight);
        }
        public XImage CreateQRCode(string text)
        {
            string textZaQRkod = "Fiskalni racun je validan i prosao je kroz proces fiskalizacije.\n\n" + text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textZaQRkod, QRCodeGenerator.ECCLevel.Q, true);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrcodeimage = qrCode.GetGraphic(20);
            Bitmap QRCodeResize = new Bitmap(qrcodeimage, new Size(200, 200));
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeResize.Save(ms, ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);

                XImage qrImage = XImage.FromStream(ms);
                return qrImage;
            }
        }
    }
    public class Interpolation
    {
        public double LinearInterpolation(double x0, double y0, double x1, double y1, double xd)
        {
            return (y0 + ((y1 - y0) * ((xd - x0) / (x1 - x0))));
        }
    }

}
