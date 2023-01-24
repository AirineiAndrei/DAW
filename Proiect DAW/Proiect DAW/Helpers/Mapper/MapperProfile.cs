using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;

namespace Proiect_DAW.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Recipe, RecipeDTO>();
        }
    }
}
