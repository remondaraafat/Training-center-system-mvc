using lab2.Models;
using lab2.Repository;
using Microsoft.EntityFrameworkCore;

namespace lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSession(option =>
            { option.IdleTimeout = TimeSpan.FromMinutes(30); });

            builder.Services.AddDbContext<Context>(
                contextBuilderOptions =>
                {
                    contextBuilderOptions.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
                });
            builder.Services.AddScoped<IDepartmntRepository, DepartmentRepository>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
