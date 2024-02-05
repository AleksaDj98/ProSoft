using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
    public partial class UCUnosPorudzbine : UserControl
    {
        private OrderControler orderControler;

        public UCUnosPorudzbine()
        {
            
        }

        public UCUnosPorudzbine(OrderControler orderControler)
        {
            this.orderControler = orderControler;
            InitializeComponent();
        }

        private void UCUnosPorudzbine_Load(object sender, EventArgs e)
        {
            
        }
    }
}
