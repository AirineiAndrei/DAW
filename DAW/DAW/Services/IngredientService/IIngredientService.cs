using DAL.Models.DTOs;

namespace DAW.Services.IngredientService
{
    public interface IIngredientService
    {
        Task<List<IngredientDTO>> GetAllIngredients();
    }
}
