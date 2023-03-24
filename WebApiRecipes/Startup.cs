using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Interfaces;
using WebApiRecipes.Repositories.Implementations;
using WebApiRecipes.Repositories.Repositories.Implementations;
using WebApiRecipes.Repositories.Repositories.Interfaces;
using WebRecipesRepositories.Interfaces;

namespace WebApiRecipes
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
            services.AddControllersWithViews();

            // Registo dos Repositórios
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IIngredientDescriptionRepository, IngredientDescriptionRepository>();
            services.AddScoped<IIngredientUnitMeasurementRepository, IngredientUnitMeasurementRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IRecipeFavoriteRepository, RecipeFavoriteRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            // Resgisto dos Serviços
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IIngredientDescriptionService, IngredientDescriptionService>();
            services.AddScoped<IIngredientUnitMeasurementService, IngredientUnitMeasurementService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IRecipeFavoriteService, RecipeFavoriteService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IUserService, UserService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
