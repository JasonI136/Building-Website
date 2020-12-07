using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Palisade.Domain.Entity;
using Palisade.Domain.Repository;
using Palisade.Interface.Domain;
using Palisade.Service;
using Palisade.Shared.Helper;

namespace Palisade.API
{
    public class Startup
    {
        readonly string palisadeSpecificOrigins = "_palisadeSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: palisadeSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200")
                                                          .AllowAnyHeader()
                                                          .AllowAnyMethod();; 
                                  });
            });
            services.AddControllers();
            services.AddDbContext<PalisadeMirandaContext>();

            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IContactUsService, ContactUsService>();
            services.AddTransient<IBuildingService, BuildingService>();

            BuildingWebsiteConfiguration.Instance.Configuration = Configuration;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(palisadeSpecificOrigins);
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
