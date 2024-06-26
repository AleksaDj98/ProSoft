﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);

        void OpenConnection();
        void CloseConnection();
        void BeginTransation();
        void CommitTransation();
        void RollbackTransation();


    }
}
