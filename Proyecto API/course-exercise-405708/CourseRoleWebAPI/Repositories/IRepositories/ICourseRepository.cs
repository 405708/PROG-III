using CourseRoleWebAPI.Dtos;
using CourseRoleWebAPI.Models;

namespace CourseRoleWebAPI.Repositories.IRepositories
{
    public interface ICourseRepository
    {
        Task<Course> AddCourse(Course course);
        Task<Course> GetCourseById(Guid courseId);
        Task<Course> UpdateCourse(CourseDto courseDto);
    }
}
