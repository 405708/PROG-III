using AutoMapper;
using CourseRoleWebAPI.ApiResponse;
using CourseRoleWebAPI.Dtos;
using CourseRoleWebAPI.Models;
using CourseRoleWebAPI.Repositories.IRepositories;
using CourseRoleWebAPI.Services.IServices;
using System.Net;

namespace CourseRoleWebAPI.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponseDto<CourseDto>> AddCourse(CourseDto courseDto)
        {
            var response = new ApiResponseDto<CourseDto>();

            var courseToMap = _mapper.Map<Course>(courseDto);

            var courseAdd = await _repository.AddCourse(courseToMap);
            if (courseAdd != null)
            {
                var courseDtoAdd = _mapper.Map<CourseDto>(courseAdd);
                response.Success = true;
                response.Data = courseDtoAdd;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se pudo agregar", System.Net.HttpStatusCode.InternalServerError);
            }
            return response;
        }

        public async Task<ApiResponseDto<CourseDto>> GetCourseById(Guid courseId)
        {
            var response = new ApiResponseDto<CourseDto>();
            var course = await _repository.GetCourseById(courseId);
            if (course != null)
            {
                var courseDto = _mapper.Map<CourseDto>(course);
                response.Data = courseDto;
                response.Success = true;
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se encontro curso con el id", System.Net.HttpStatusCode.InternalServerError);
            }
            return response;
        }

        public async Task<ApiResponseDto<CourseDto>> UpdateCourse(CourseDto courseDto)
        {
            var response = new ApiResponseDto<CourseDto>();

            var courseUpdate = await _repository.UpdateCourse(courseDto);

            if (courseUpdate != null)
            {
                var courseUpdatedDto = _mapper.Map<CourseDto>(courseUpdate);
                courseUpdatedDto.Id = courseUpdate.Id;
                courseUpdatedDto.CourseTypeId = courseUpdate.CourseTypeId;
                courseDto.Name = courseUpdate.Name;
                courseDto.Description = courseUpdate.Description;

                response.Data = courseUpdatedDto;
                response.Success = true;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.SetError("No se pudo modificar el curso", HttpStatusCode.InternalServerError);
            }
            return response;
        }
    }
}
