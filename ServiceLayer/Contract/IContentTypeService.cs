using System;
using System.Linq.Expressions;
using DataLayer.Entities;

namespace ServiceLayer.Contract
{
    public interface IContentTypeService
    {
        Task<int?> GetIdWithCondition(Expression<Func<ContentType, bool>> Condition);
        //Task<IQueryable<TblUserComment>> FindAll();
        //Task<IQueryable<TblUserComment>> FindListByCondition(Expression<Func<TblUserComment, bool>> Condition);
        Task<ContentType> FindByCondition(Expression<Func<ContentType, bool>> Condition);

        Task<bool> Delete(int Id);



        Task<IQueryable<ContentType>> FindListByCondition(Expression<Func<ContentType, bool>> Condition);


        Task<IQueryable<ContentType>> FindAll();

        Task<ContentType> Create(ContentType NewContentType);

        Task<ContentType> GetWithId(int Id);


    }
}

