using System;
using System.Linq;
using System.Linq.Expressions;
using DataLayer.Entities;
using RepositoryLayer.Contract;

namespace RepositoryLayer.Repository
{
    public class DapperRepository : IDapperRepository
    {
        private DapperDbContext _db;
        public DapperRepository(DapperDbContext dapperDbContext)
        {
            _db = dapperDbContext;

        }

        public async Task<IQueryable<object>> GetAllContent()
        {
            //var sql = @"SELECT *
            //FROM Content As _content
            //INNER JOIN UserAccount AS _user
            //ON  _content.AuthorUserAccountID= _user.ID
            //WHERE _content.Confirmed = 1";
            var sql = @"SELECT TOP 200 * 
FROM Content  AS _content
INNER JOIN UserAccount AS _user ON _content.AuthorUserAccountID = _user.ID
WHERE _content.Confirmed = 1";
            //            var sql = @"SELECT *
            //FROM Content As _content
            //INNER JOIN UserAccount AS _user
            //ON  _content.AuthorUserAccountID= _user.ID
            //WHERE _content.IntID = 4599";
            var result = (await _db.QueryAsync<object>(sql));
            return result.AsQueryable();
        }
    }
}

