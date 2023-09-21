using System;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Contract;
using ServiceLayer.Services;

namespace IocLayer

{
	public static partial class ServicesDependency
	{
		public static void AddServiceDependency(this IServiceCollection services)
		{
            services.AddTransient<IUserAccountService, UserAccountService>();
            services.AddTransient<IContentService, ContentService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IContentTypeService, ContentTypeService>();
        }
	}
}

