using System.Diagnostics;

namespace Exam.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public Department? Department { get; set; }
        public Employee? Employee { get; set; }

    }
}
