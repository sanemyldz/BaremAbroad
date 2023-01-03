using AutoMapper;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.DTOs.BlogArticle;
using BaremAbroad.Repository.DTOs.User;
using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserResponseDTO>().ReverseMap();
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<User, UpdateUserDTO>().ReverseMap();
            CreateMap<User, LoginUserDTO>().ReverseMap();
            CreateMap<Faq, FaqDTO>().ReverseMap();
            CreateMap<UserPassword, UserPasswordDTO>().ReverseMap();
            CreateMap<BlogArticle, BlogArticleResponseDTO>().ReverseMap();
            CreateMap<BlogArticle, CreateBlogArticleDTO>().ReverseMap();
            CreateMap<BlogArticle, UpdateBlogArticleDTO>().ReverseMap();
            CreateMap<BlogCategory, BlogCategoryDTO>().ReverseMap();
            CreateMap<Program, ProgramDTO>().ReverseMap();
            CreateMap<UserComment, UserCommentDTO>().ReverseMap();

        }
    }
}
