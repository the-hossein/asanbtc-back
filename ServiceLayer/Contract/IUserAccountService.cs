using System;
using System.Linq.Expressions;
using DataLayer.Entities;

namespace ServiceLayer.Contract
{
    public interface IUserAccountService
    {
        Task<int?> GetIdWithCondition(Expression<Func<UserAccount, bool>> Condition);
        //Task<IQueryable<TblUserComment>> FindAll();
        //Task<IQueryable<TblUserComment>> FindListByCondition(Expression<Func<TblUserComment, bool>> Condition);
        Task<UserAccount> FindByCondition(Expression<Func<UserAccount, bool>> Condition);

        Task<bool> Delete(int Id);



        Task<IQueryable<UserAccount>> FindListByCondition(Expression<Func<UserAccount, bool>> Condition);


        Task<IQueryable<UserAccount>> FindAll();
    }
}

