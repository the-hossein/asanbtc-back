using System;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using IocLayer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DataLayer.Enums;
using System.Security.Claims;
using Microsoft.OpenApi.Models;

namespace asanbtc_api
{
    public class Startup
    {
        public IConfiguration _Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;

        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<AsanBtcDbContext>(options =>
                      options.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection")));

            services.AddRepositoryInstance();
            services.AddServiceDependency();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      .AddJwtBearer(options =>
      {
          options.SaveToken = true;
          options.RequireHttpsMetadata = false;
          options.TokenValidationParameters = new TokenValidationParameters()
          {
              ValidateIssuer = true,
              ValidateAudience = true,
              ValidAudience = _Configuration["Jwt:Audience"],
              ValidIssuer = _Configuration["Jwt:Issuer"],

              IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"])),

          };
      });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                    policy.RequireClaim(ClaimTypes.Role, UserRole.Admin.ToString())
                    .RequireAssertion(context =>
                        context.User.HasClaim(claim =>
                            claim.Type == ClaimTypes.NameIdentifier
                        )
                        )
                );
                options.AddPolicy("User", policy =>
                   policy.RequireClaim(ClaimTypes.Role, UserRole.User.ToString())
                   .RequireAssertion(context =>
                       context.User.HasClaim(claim =>
                           claim.Type == ClaimTypes.NameIdentifier

                       )
                   )


               );
            });
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = " Floor v1 API's",
                    Description = $"Floor API's for integration with UI \r\n\r\n © Copyright {DateTime.Now.Year} JK. All rights reserved."
                });
                //swagger.ResolveConflictingActions(a => a.First());


                #region Enable Authorization using Swagger (JWT) 
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });

                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
        {
              new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] {}

        }
                });
                #endregion
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");

                });
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowCors");


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
            });

        }
    }
}

