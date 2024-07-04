using AutoMapper;
using CourseRoleWebAPI.Dtos;
using CourseRoleWebAPI.Models;



namespace CourseRoleWebAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.CourseTypeId, opt => opt.MapFrom(src => src.CourseTypeId));

            CreateMap<CourseDto, Course>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.CourseTypeId, opt => opt.MapFrom(src => src.CourseTypeId));


            CreateMap<Log, LogDto>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data))
            .ForMember(dest => dest.DataId, opt => opt.MapFrom(src => src.DataId))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

            CreateMap<LogDto, Log>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data))
            .ForMember(dest => dest.DataId, opt => opt.MapFrom(src => src.DataId))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));


            CreateMap<CourseType, CourseTypeDto>();
            CreateMap<Permission, PermissionDto>();

        }
    }
}
