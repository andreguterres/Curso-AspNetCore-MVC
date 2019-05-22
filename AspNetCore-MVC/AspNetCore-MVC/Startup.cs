using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Interfaces;
using AspNetCore_MVC.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCore_MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //INJEÇÃO DE DEPENDENCIA.
            // AddTransient chama a interface "IPeopleRepository"e cria uma nova instancia do que for
            // passado como parametro dentro do parenteses.
            services.AddTransient<IPeopleRepository>(repository => new PeopleRepository("servidor"));


            // services.AddScoped cria nova instancia por requisição, acessa diversas classes conforme for necessária
            //e usa a mesma instancia para cada chamada do IPeopleRepository.(Por requisição).
            // Se usuário fizer uma nova chamada ele instaciara novamene.
            //services.AddScoped<IPeopleRepository>(repository => new PeopleRepository(""));


            //Acessará paenas uma classe completa. Vai instanciar e vai usar somente uma classe, mesma instancia.
            //Serve para classes pesadas.
            //services.AddSingleton<IPeopleRepository>(repository => new PeopleRepository(""));


            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddMvc();

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Testando o ambiente que está sendo utilizado.
            Console.WriteLine($" Banco_Usado {Configuration["ConnectString"]}");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes
                .MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}")
                // Rota Customizada 
                .MapRoute(
                    name: "privado",
                    template: "privacy",
                    defaults: new { controller = "Home", action = "Privacy" }

                    );
            });
        }
    }
}
