using ApiSolution.DTO;
using ApiSolution.Infrastructure.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSolution.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper;
        public static void ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            Mapper = config.CreateMapper();
        }
    }
    //public class MappingProfile : Profile
    //{
    //    public MappingProfile()
    //    {
    //        CreateMap<Posts, PostDto>();
    //        CreateMap<PostDto, Posts>();

    //        CreateMap<Comments, CommentsDto>();
    //        CreateMap<CommentsDto, Comments>();

    //        //.ForMember(x => x.UserName, opt => opt.MapFrom(y => y.FirstName + " " + y.MiddleName + " " + y.LastName))
    //        //.ForMember(x => x.UserAddress, opt => opt.MapFrom(y => y.AddressLine1 + " " + y.AddressLine2 + " " + y.PinCode));
    //    }
    //}
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Posts, PostDto>();
            //CreateMap<PostDto, Posts>();

            //CreateMap<Comments, CommentsDto>();
            //CreateMap<CommentsDto, Comments>();


            //.ForMember(x => x.UserName, opt => opt.MapFrom(y => y.FirstName + " " + y.MiddleName + " " + y.LastName))
            //.ForMember(x => x.UserAddress, opt => opt.MapFrom(y => y.AddressLine1 + " " + y.AddressLine2 + " " + y.PinCode));
        }
    }
}