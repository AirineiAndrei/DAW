using AutoMapper;
using DAL.Models.DTOs;
using DAL.Repositories.RecipeRepository;

namespace DAW.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        public IRecipeRepository _recipeRepository;
        public IMapper _mapper;

        public RecipeService(IRecipeRepository recipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            var recipes = await _recipeRepository.GetAll();
            List<RecipeDTO> result = _mapper.Map<List<RecipeDTO>>(recipes);

            return result;
        }

        public async Task DeleteRecipe(Guid recipeId)
        {
            var studentToDelete = await _recipeRepository.FindByIdAsync(recipeId);
            _recipeRepository.Delete(studentToDelete);
            await _recipeRepository.SaveAsync();
        }

    }
}
