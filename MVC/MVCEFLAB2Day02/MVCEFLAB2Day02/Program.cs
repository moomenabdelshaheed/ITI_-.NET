using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEFLAB2Day02.Models;
using MVCEFLAB2Day02.Repository;

namespace MVCEFLAB2Day02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ITIcontext>
                (optionBuilder=>optionBuilder.
                UseSqlServer(builder.Configuration.GetConnectionString("M3M")));
            builder.Services.AddSession();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            //builder.Services.AddScoped<ICourseRepository, testtemprepository>();

            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.MapStaticAssets();
          
            app.MapControllerRoute("route1","MO/{name:alpha}/{age:int:range(18,60)}",new { controller= "Courses", action= "Index" });
            app.MapControllerRoute("defaultByMo", "{controller=Courses}/{action=Index}/{id?}");
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}")
            //    .WithStaticAssets();

            app.Run();
        }
    }
}
