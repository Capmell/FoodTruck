

using FoodTruck.Models;
using Microsoft.EntityFrameworkCore;
//using FoodTruck.Data;
using Microsoft.AspNetCore.Identity;
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
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodTruckConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FoodTruckContext>();

            var app = builder.Build();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "BookBarn API", Version = "v1" });

                // Only include API routes (ignore MVC view controllers)
                c.DocInclusionPredicate((docName, apiDesc) =>
                    apiDesc.RelativePath != null &&
                    apiDesc.RelativePath.StartsWith("api/", StringComparison.OrdinalIgnoreCase));
            });

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

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





            app.Run();
        }
    }
}
