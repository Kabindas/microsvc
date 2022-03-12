using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using microsvc.services.DbRepos.Order;
using microsvc.services.DbRepos.User;
using microsvc.services.Services.Imp;
using microsvc.services.Services.Interfaces;

namespace microsvc.web
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
            services.AddDbContext<orderContext>(options => options.UseSqlite(Configuration.GetConnectionString("OrderConnection"),
                builder => builder.MigrationsAssembly("microsvc.services")));
            services.AddDbContext<userContext>(options => options.UseSqlite(Configuration.GetConnectionString("UserConnection"),
                builder => builder.MigrationsAssembly("microsvc.services")));

            services.AddSwaggerGen();
            services.AddTransient<IOrderSvc, OrderSvc>();
            services.AddTransient<IUserSvc, UserSvc>();
            services.AddTransient<IUsersOrdersSvc, UsersOrdersSvc>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

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
