using CodeFirst.Models;
using CodeFirst.Models.DataManager;
using CodeFirst.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CodeFirst.API
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
            services.AddDbContext<EmployeeContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:DefaultConnection"],
                optsAssemlby => optsAssemlby.MigrationsAssembly("CodeFirst.API")));
            services.AddScoped<IDataRepository<Employee>, EmployeeManager>();

            services.AddDbContext<CartContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:DefaultConnection"],
                optsAssemlby => optsAssemlby.MigrationsAssembly("CodeFirst.API")));
            services.AddScoped<ICartDataRepository<Cart>, CartManager>();

            services.AddDbContext<CartItemContext>(opts =>
                opts.UseSqlServer(Configuration["ConnectionString:DefaultConnection"],
                optsAssemlby => optsAssemlby.MigrationsAssembly("CodeFirst.API")));
            services.AddScoped<ICartItemDataRepository<CartItem>, CartItemManager>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvcCore().AddApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = "https://twitter.com/spboyer"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc();

        }


    }
}
