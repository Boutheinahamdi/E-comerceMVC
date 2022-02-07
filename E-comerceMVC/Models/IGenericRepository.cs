﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Models
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
