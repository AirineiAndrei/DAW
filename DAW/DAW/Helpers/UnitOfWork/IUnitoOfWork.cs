using DAL.Repositories.CommentRepository;
using DAL.Repositories.IngredientInRecipeRepository;
using DAL.Repositories.IngredientRepository;
using DAL.Repositories.RecipeRepository;
using DAL.Repositories.UserRepository;

namespace DAW.Helpers.UnitOfWork
{
    public interface IUoW
    {
        IRecipeRepository RecipeRepo { get; }
        ICommentRepository CommentRepo { get; }
        IIngredientRepository IngredientRepo { get; }
        IUserRepository UserRepo { get; }
        IIngredientInRecipeRepository IngredientInRecipeRepo { get; }
    }
}
