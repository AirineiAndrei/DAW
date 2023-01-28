using DAL.Repositories.RecipeRepository;
using DAL.Repositories.IngredientRepository;
using Proiect_DAW.Services.RecipeService;
using DAL.Repositories.IngredientRepository.cs;
using DAL.Repositories.CommentRepository.cs;
using DAL.Repositories.IngredientInRecipeRepository;

namespace Proiect_DAW.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IIngredientInRecipeRepository,IngredientInRecipeRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddTransient<IRecipeService, RecipeService>();

            return services;
        }
    }
}
