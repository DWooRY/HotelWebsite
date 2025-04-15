﻿using AutoMapper;
using HotelWebsite.EntityLayer.Concrete;
using HotelWebsite.WebUI.Dtos.LoginDto;
using HotelWebsite.WebUI.Dtos.RegisterDto;
using HotelWebsite.WebUI.Dtos.ServiceDto;

namespace HotelWebsite.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
