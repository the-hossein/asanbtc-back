using System;
using DataLayer.Entities;
using RepositoryLayer.Contract;

namespace RepositoryLayer.Repository
{
    public class UserAccountRepository : RepositoryBase<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(AsanBtcDbContext Context) : base(Context) { }
    }
}

