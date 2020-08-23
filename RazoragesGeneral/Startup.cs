using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazoragesGeneralLesens.Services;

namespace RazoragesGeneral
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Этот метод вызывается средой выполнения. Используйте этот метод для добавления служб в контейнер.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(); //подключен RazorPages
            
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>(); // Подключаем зависимость с Бд

        }

        // Этот метод вызывается средой выполнения. Используйте этот метод для настройки конвейера HTTP-запросов.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // Значение HSTS по умолчанию равно 30 дням. Возможно, вы захотите изменить это для производственных сценариев, см. https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // использование статик файлов 

            app.UseRouting(); //маршрутизация

            app.UseAuthorization();

            //точка запуска маршрута
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
