using System;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using ServiceLayer.Contract;
using RepositoryLayer.Contract;
using DataLayer.Entities;

namespace ServiceLayer.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IUserAccountRepository _User;

        public UserAccountService(IUserAccountRepository User)
        {

            _User = User;
        }

        public async Task<UserAccount> FindByCondition(Expression<Func<UserAccount, bool>> Condition)
        {
            try
            {
                return _User.FindByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }

        public async Task<IQueryable<UserAccount>> FindAll()
        {

            try
            {
                return await _User.FindAll();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }

        public async Task<bool> Delete(int id)
        {

            try
            {
                var TheUser = _User.FindByCondition(a => a.Id == id);
                var Result = _User.Delete(TheUser);
                return Result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<IQueryable<UserAccount>> FindListByCondition(Expression<Func<UserAccount, bool>> Condition)
        {

            try
            {
                return _User.FindListByCondition(Condition);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);

                return null;
            }
        }
        public async Task<int?> GetIdWithCondition(Expression<Func<UserAccount, bool>> Condition)
        {
            try
            {
                var FoundRecord = _User.FindByCondition(Condition);
                if (FoundRecord != null)
                    return FoundRecord.Id;
                else
                    return null;
            }
            catch (Exception)
            {
                Console.Write("This User Is not Exist");

                return null;
            }

        }
    }
}

