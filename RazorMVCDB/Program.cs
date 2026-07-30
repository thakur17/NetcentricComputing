using Microsoft.EntityFrameworkCore;
using mysqldb.Model;

namespace mysqldb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // 1. Get the connection string from appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("Connection1");

            // 2. Register your DbContext class using Pomelo MySQL provider
            builder.Services.AddDbContext<SupplierContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
