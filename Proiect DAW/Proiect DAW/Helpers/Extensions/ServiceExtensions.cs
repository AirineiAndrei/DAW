using DAL.Repositories.RecipeRepository;
using Proiect_DAW.Services.RecipeService;

namespace Proiect_DAW.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddTransient<IRecipeRepository, RecipeRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddTransient<IRecipeService, RecipeService>();

            return services;
        }
    }
}
