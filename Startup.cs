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
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using MineApi.Models;
using MineApi.Data;

namespace MineApi
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

            services.AddControllers();
            services.AddDbContext<AboutMeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<AcademicRecordContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<AuthAdminContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<OtherInterestContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<PersonalDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<ProjectDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<RecieveMassageContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<SendMassageContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<SkillDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<SocialMediaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<TrainingDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddDbContext<WorkExpContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebDataString")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MineApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MineApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
