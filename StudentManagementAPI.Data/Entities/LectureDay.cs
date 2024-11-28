namespace StudentManagementAPI.Data.Entities
{
    public class LectureDay
    {
        public Guid ID { get; set; }
        public Guid GroupID { get; set; }
        public Group Group { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        
    }
}
