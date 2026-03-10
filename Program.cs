

using FoodTruck.Models;
using FoodTruck.Services;
using FoodTruck.Services.Interfaces;
//using FoodTruck.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using FoodTruck.Data;
namespace FoodTruck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<FoodTruckContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookBarnConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FoodTruckContext>();

            builder.Services.AddScoped<IFoodService, FoodService>();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "FoodTruck API", Version = "v1" });

                // Only include API routes (ignore MVC view controllers)
                c.DocInclusionPredicate((docName, apiDesc) =>
                    apiDesc.RelativePath != null &&
                    apiDesc.RelativePath.StartsWith("api/", StringComparison.OrdinalIgnoreCase));
            });

            var app = builder.Build();

        

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            builder.Services.AddEndpointsApiExplorer();

           

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
name: "default",
pattern: "{controller=Menu}/{action=Index}/{id?}");





            app.Run();
        }
    }
}
