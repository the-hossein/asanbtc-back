using System;
using System.Data.SqlClient;
using Dapper;
using Dapper.ORM;
using Microsoft.Extensions.Configuration;

namespace RepositoryLayer
{
    public class DapperDbContext : DapperContext
    {

        public DapperDbContext(IConfiguration _Configuration) : base(_Configuration.GetConnectionString("DefaultConnection"))
        {
        }

    }
}

