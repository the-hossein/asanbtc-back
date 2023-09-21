using System;
using System.Linq.Expressions;
using DataLayer.Entities;

namespace ServiceLayer.Contract
{
    public interface IContentService
    {
        Task<int?> GetIdWithCondition(Expression<Func<Content, bool>> Condition);
        //Task<IQueryable<TblUserComment>> FindAll();
        //Task<IQueryable<TblUserComment>> FindListByCondition(Expression<Func<TblUserComment, bool>> Condition);
        Task<Content> FindByCondition(Expression<Func<Content, bool>> Condition);

        Task<bool> Delete(int Id);



        Task<IQueryable<Content>> FindListByCondition(Expression<Func<Content, bool>> Condition);


        Task<IQueryable<Content>> FindAll();

        Task<Content> Create(Content NewContent);

        Task<Content> GetWithId(int Id);

        Task<IQueryable<object>> FindWithTypeId(int ContentType);
    }
}

