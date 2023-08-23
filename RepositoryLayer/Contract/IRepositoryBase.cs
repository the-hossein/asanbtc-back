using System;
using System.Linq.Expressions;

namespace RepositoryLayer.Contract
{
    public interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> FindAll();
        IQueryable<T> FindListByCondition(Expression<Func<T, bool>> expression);
        T FindByCondition(Expression<Func<T, bool>> expression);
        public T Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        int GetALlFilteredByCount(Expression<Func<T, bool>> expression);
        int GetAllCount();
    }
}

