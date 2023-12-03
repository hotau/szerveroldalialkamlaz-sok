using GAMF.Data;
using Microsoft.EntityFrameworkCore;

namespace GAMF
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GAMFContext>(options => options.UseSqlServer(
                Configuration["ConnectionStrings:GAMFDbConnection"]));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }

}
