using DAL.Data;
using DAL.Repositories.CommentRepository;
using DAL.Repositories.IngredientInRecipeRepository;
using DAL.Repositories.IngredientRepository;
using DAL.Repositories.RecipeRepository;
using DAL.Repositories.UserRepository;

namespace DAW.Helpers.UnitOfWork
{
    public class UoW : IUoW
    {
        public IRecipeRepository RecipeRepo { get; }
        public ICommentRepository CommentRepo { get; }
        public IIngredientRepository IngredientRepo { get; }
        public IUserRepository UserRepo { get; }
        public IIngredientInRecipeRepository IngredientInRecipeRepo { get; }
        public readonly AppDbContext _context;

        public UoW(IRecipeRepository recipeRepo, ICommentRepository commentRepo, IIngredientRepository ingredientRepo, IUserRepository userRepo, IIngredientInRecipeRepository ingredientInRecipeRepo, AppDbContext context)
        {
            RecipeRepo = recipeRepo;
            CommentRepo = commentRepo;
            IngredientRepo = ingredientRepo;
            UserRepo = userRepo;
            IngredientInRecipeRepo = ingredientInRecipeRepo;
            _context = context;
        }
    }
}
