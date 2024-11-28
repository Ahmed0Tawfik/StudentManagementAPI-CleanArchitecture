namespace StudentManagementAPI.Data.Entities
{
    public class TestResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime TestDate { get; set; }
        public decimal Grade { get; set; }
    }
}

