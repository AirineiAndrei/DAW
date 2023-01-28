using AutoMapper;
using DAL.Repositories.IngredientRepository;

namespace Proiect_DAW.Services.IngredientService
{
    public class IngredientService
    {
        public IIngredientRepository _ingredientRepository;
        public IMapper _mapper;
        public IngredientService(IIngredientRepository ingredientRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }   
    }
}
