﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{ //Sistemi veri tabanı nesleri ile çalıştırmak için;
   //Generic Constraint :Generic kısıt, gönderilecek neslerikısıtlama
   //class:Reference
   //IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
   //new():new'lenebilir olmalı,interface new lenemediği için onları da sınırladık
   public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


       
    }
}
