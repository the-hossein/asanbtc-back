using System;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer;
using RepositoryLayer.Contract;
using RepositoryLayer.Repository;

namespace IocLayer
{
    public static partial class RepositoryInstance
    {
        public static void AddRepositoryInstance(this IServiceCollection services)
        {
            services.AddScoped<DapperDbContext>();
            services.AddScoped<IDapperRepository, DapperRepository>();
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
            services.AddScoped<IContentRepository, ContentRepository>();
            services.AddScoped<IContentTypeRepository, ContentTypeRepository>();
        }
    }
}

