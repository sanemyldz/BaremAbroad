using AutoMapper;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Faq, FaqDTO>().ReverseMap();
            CreateMap<UserPassword, UserPasswordDTO>().ReverseMap();
            CreateMap<BlogArticle, BlogArticleDTO>().ReverseMap();
            CreateMap<BlogCategory, BlogCategoryDTO>().ReverseMap();
            CreateMap<Program, ProgramDTO>().ReverseMap();
            CreateMap<UserComment, UserCommentDTO>().ReverseMap();
  
        }
    }
}
