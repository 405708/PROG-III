namespace CourseRoleWebAPI.Dtos
{
    public class LogDto
    {
        public Guid Id { get; set; }
        public string Data { get; set; }
        public Guid DataId { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
    }
}
