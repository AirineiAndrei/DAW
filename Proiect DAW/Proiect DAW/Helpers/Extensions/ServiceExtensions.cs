using DAL.Repositories.RecipeRepository;
using DAL.Repositories.IngredientRepository;
using Proiect_DAW.Services.RecipeService;
using DAL.Repositories.CommentRepository;
using DAL.Repositories.IngredientInRecipeRepository;
using Proiect_DAW.Services.IngredientService;
using Proiect_DAW.Services.CommentService;
using DAL.Repositories.UserRepository;
using Proiect_DAW.Services.UserService;
using Proiect_DAW.Helpers.Jwt;

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
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddTransient<IIngredientService, IngredientService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddTransient<IJwtUtils, JwtUtils>();

            return services;
        }
    }
}
