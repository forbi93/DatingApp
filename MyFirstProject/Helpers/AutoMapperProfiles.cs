using AutoMapper;
using MyFirstProject.DTOs;
using MyFirstProject.Entities;
using MyFirstProject.Extensions;

namespace MyFirstProject.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>()
            .ForMember(dest => dest.PhotoUrl,
                opt =>
                    opt.MapFrom(src =>
                        src.Photos.FirstOrDefault(x => x.IsMain).Url))
            .ForMember(dest => dest.Age, opt
                => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
        CreateMap<Photo, PhotoDto>();
    }
}