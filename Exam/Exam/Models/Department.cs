using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string? Title { get; set; }       
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
