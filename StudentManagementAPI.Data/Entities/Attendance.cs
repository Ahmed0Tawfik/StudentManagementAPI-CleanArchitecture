namespace StudentManagementAPI.Data.Entities
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime LectureDate { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public bool IsPresent { get; set; }
    }
}
