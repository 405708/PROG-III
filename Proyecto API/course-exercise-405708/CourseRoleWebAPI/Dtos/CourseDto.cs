namespace CourseRoleWebAPI.Dtos
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public Guid CourseTypeId { get; set; }
    }
}
