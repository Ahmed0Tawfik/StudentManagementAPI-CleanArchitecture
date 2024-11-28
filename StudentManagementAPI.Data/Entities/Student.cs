namespace StudentManagementAPI.Data.Entities
{
    public class Student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid GroupID { get; set; }
        public Group Group { get; set; }
        public string ParentPhone { get; set; }
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        public bool IsFeePaidForMonth(int month, int year)
        {
            return Payments.Any(fp => fp.Month == month && fp.Year == year && fp.PaymentStatus == Enums.PaymentStatus.NotPaid);
        }

    }
}
