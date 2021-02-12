using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   public interface IEntityRepository<T> where T:class,IEntity,new()//newlenebilir IEntity imlementasyonu
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//expression koşullandırmayı sağlar =>where
        T Get(Expression<Func<T,bool>> filter);//filtre zorunlu=>where
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       // List<T> GetAllByCategory(int categoryId);
    }
}
