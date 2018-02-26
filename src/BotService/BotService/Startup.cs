using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotService.Domain.Repo;
using BotService.Infrastructure.Repositories;
using BotService.Interface.Contracts;
using BotService.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BotService
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
            services.AddMvc();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBotService, Service.BotService>();
            services.AddTransient<ICustomerAccountRepo, FakeCustomerAccountRepo>();
            services.AddTransient<ICustomerRepo, FakeCustomerRepo>();
            services.AddTransient<ICustomerService, CustomerService>(); 


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
