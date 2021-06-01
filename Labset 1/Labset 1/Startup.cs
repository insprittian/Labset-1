﻿using Labset_1.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace Labset_1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<BlogDataContext>(options =>
            {
                string connectionString = @"Server=(LocalDb)\MSSQLLocalDb;Database=AspNetBlog";
                options.UseSqlServer(connectionString);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(
                routes => routes.MapRoute("Default",
                "{controller=Home}/{action=Index}/{id?}"));
            //app.UseStaticFiles();
            app.UseFileServer();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello ASP.NET!");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello C#!");
            //});
        }
    }
}
