﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class:referans tip
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı(interfaceler newlenemez)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Uptade(T entity);
        void Delete(T entity);
        
    }
}
