using Infrastraction;
using Infrastraction.Interface;
using Infrastraction.Repostory;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

namespace Movie_Ticket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);


            builder.Services.AddLocalization(option =>
            {

                option.ResourcesPath = "Recources";
              
            });

            builder.Services.Configure<RequestLocalizationOptions>(
                option =>
                {
                    var supportedCulutes = new[]
                    {
                        new CultureInfo("en")
                    };
                    option.DefaultRequestCulture = new RequestCulture("en");
                    option.SupportedCultures = supportedCulutes;
                }

                );


            // builder.Services.AddScoped<IMovieRepostory, MovieRepostory>();
            builder.Services.AddScoped<IUniteOfWork, UniteOfWork>();
            builder.Services.AddScoped<IMovieRepostory, MovieRepostory>();
            builder.Services.AddDbContext<MVContext>();
            var app = builder.Build();
            app.UseRequestLocalization();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}