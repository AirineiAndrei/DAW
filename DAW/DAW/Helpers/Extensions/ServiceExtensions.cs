using DAL.Repositories.RecipeRepository;
using DAL.Repositories.IngredientRepository;
using DAW.Services.RecipeService;
using DAL.Repositories.CommentRepository;
using DAL.Repositories.IngredientInRecipeRepository;
using DAW.Services.IngredientService;
using DAW.Services.CommentService;
using DAL.Repositories.UserRepository;
using DAW.Services.UserService;
using DAW.Helpers.Jwt;
using DAW.Helpers.UnitOfWork;

namespace DAW.Helpers.Extensions
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
        public static IServiceCollection AddUoW(this IServiceCollection services)
        {
            services.AddTransient<IUoW, UoW>();

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
