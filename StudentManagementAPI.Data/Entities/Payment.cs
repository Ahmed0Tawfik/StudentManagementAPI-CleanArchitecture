using StudentManagementAPI.Data.Enums;

namespace StudentManagementAPI.Data.Entities
{
    public class Payment
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Student Student { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
