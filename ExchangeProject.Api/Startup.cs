using ExchangeProject.Business.Abstract;
using ExchangeProject.Business.Concrete.Services;
using ExchangeProject.Common.DataAccess;
using ExchangeProject.Common.DataAccess.EntityFramework;
using ExchangeProject.DataAccess.Abstract;
using ExchangeProject.DataAccess.Concrete.EntityFramework;
using ExchangeProject.DataAccess.Concrete.EntityFramework.Context;
using ExchangeProject.DataAccess.Concrete.EntityFramework.Repositories;
using ExchangeProject.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeProject.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ExchangeDbContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ExchangeDbContext>().AddDefaultTokenProviders();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExchangeProject.Api", Version = "v1" });
            });

            services.AddScoped<IUow, Uow>();
            services.AddScoped<ICoinService, CoinService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExchangeProject.Api v1"));
            }

            app.UseHttpsRedirection();

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
