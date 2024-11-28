using StudentManagementAPI.Data.Enums;

namespace StudentManagementAPI.Data.Entities
{
    public class Group
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid EducationYearID { get; set; }
        public EducationYear EducationYear { get; set; }
        public decimal Payment { get; set; }
        public ICollection<LectureDay> LectureDays { get; set; } = new List<LectureDay>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
