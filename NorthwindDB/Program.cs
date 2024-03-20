using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NorthwindDb; // To use AddNorthwindContext method.
internal class Program
{
    private static void Main(string[] args)
    {
        //NorthwindContext context = new NorthwindContext();

        var builder = WebApplication.CreateBuilder(args);

        // Add servi..ces to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<NorthwindContext>(options => 
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        
            var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}