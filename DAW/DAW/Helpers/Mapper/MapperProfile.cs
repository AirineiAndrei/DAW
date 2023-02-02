using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;

namespace DAW.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Recipe, RecipeDTO>();
            CreateMap<Ingredient, IngredientDTO>();
            CreateMap<Comment, CommentDTO>();
        }
    }
}
