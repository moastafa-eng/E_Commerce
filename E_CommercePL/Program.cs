using E_CommerceDAL.Data.Contexts;
using E_CommerceDAL.Data.DataSeeding;
using Microsoft.EntityFrameworkCore;

namespace E_CommercePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();

            // Add DbContext Service

            // Pass options to base class throw instructor in E_CommerceDbContext.
            builder.Services.AddDbContext<E_CommerceDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            var app = builder.Build();

            #region Data Seeding

            // Create a temporary scope because DbContext is scoped, 
            // and there is no HTTP request during Data Seeding
            var Scope = app.Services.CreateScope(); // Create Scope
            var dbContextObj = Scope.ServiceProvider.GetRequiredService<E_CommerceDbContext>(); // Create obj from context

            E_CommerceDataSeeding.SeedData(dbContextObj);

            #endregion

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
