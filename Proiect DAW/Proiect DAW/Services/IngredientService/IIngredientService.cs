using DAL.Models.DTOs;

namespace Proiect_DAW.Services.IngredientService
{
    public interface IIngredientService
    {
        Task<List<IngredientDTO>> GetAllIngredients();
    }
}
