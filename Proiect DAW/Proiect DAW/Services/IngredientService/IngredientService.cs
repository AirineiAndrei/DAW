using AutoMapper;
using DAL.Models.DTOs;
using DAL.Repositories.IngredientRepository;
using System.Reflection.Metadata.Ecma335;

namespace Proiect_DAW.Services.IngredientService
{
    public class IngredientService : IIngredientService
    {
        public IIngredientRepository _ingredientRepository;
        public IMapper _mapper;
        public IngredientService(IIngredientRepository ingredientRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }

        public async Task<List<IngredientDTO>> GetAllIngredients()
        {
            var ingredients = await _ingredientRepository.GetAll();
            List<IngredientDTO> result = _mapper.Map<List<IngredientDTO>>(ingredients);
            return result;
        }
    }
}
