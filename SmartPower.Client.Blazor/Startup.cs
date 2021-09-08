using Blazored.Modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartPower.Client.Blazor.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartPower.Client.Blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<Application.Entity.DbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SmartPowerDatabaseConnectionstring")));

            services.AddTransient<Application.Entity.Repository.IBulkReversal, Application.Entity.Repository.BulkReversal>();
            services.AddTransient<Application.Entity.Repository.IInvoice, Application.Entity.Repository.Invoice>();

            services.AddTransient<Application.Service.BulkReversal.ICsvExport, Application.Service.BulkReversal.CsvExport>();

            services.AddSingleton<WeatherForecastService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
