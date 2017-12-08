using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;
using System.IO;
using MoviesDb.DAL;
using MoviesApi.Interfaces;
using MoviesApi.Services;

namespace MoviesApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddAutoMapper(opt => opt.CreateMissingTypeMaps = true, Assembly.GetEntryAssembly());

            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<MoviesApiDbContext>();

            //services.AddSwaggerGen(sw =>
            //{
            //    sw.SwaggerDoc("ver.1", new Info { Version = "ver.1", Title = "Movies Api" });
            //    sw.CustomSchemaIds(i => i.FullName);
            //    var basePath = System.AppContext.BaseDirectory;
            //    var xmlPath = Path.Combine(basePath, "MoviesApi.xml");
            //    sw.IncludeXmlComments(xmlPath);
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseSwagger();

            //app.UseSwaggerUI(sw =>
            //{
            //    var swaggerPath = "/swagger/ver.1/swagger.json";
            //    sw.SwaggerEndpoint(swaggerPath, "Movies Api Ver.1");
            //});
        }
    }
}
