using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ExercisesAPI.Database;
using ExercisesAPI.Models;

namespace ExercisesAPI
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
            services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase());
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var context = serviceProvider.GetService<ApiContext>();
                AddTestData(context);
             }

            app.UseMvc();
        }

        public void AddTestData(ApiContext context)
        {
            var testData = new Act[]{
                new Act
                {
                    Id = 1,
                    Name = "Squat"
                },

                new Act
                {
                    Id = 2,
                    Name = "Bench"
                },

                new Act
                {
                    Id = 3,
                    Name = "Deadlift"
                }
            };

            for(int i = 0; i < testData.Length; i++)
            {
                context.Actions.Add(testData[i]);
            }
            context.SaveChanges();
        }
    }
}
