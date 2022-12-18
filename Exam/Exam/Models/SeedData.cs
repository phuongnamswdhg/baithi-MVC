using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Exam.Data;
using System;
using System.Linq;
namespace Exam.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeeContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }
                var employees = new Employee[]
                {
                    new Employee { EmployeeName = "Huy",Salary=1000, EnrollmentDate = DateTime.Parse("2005-09-01") },
                    new Employee { EmployeeName = "Ha",Salary=2000, EnrollmentDate = DateTime.Parse("2002-09-01") },
                    new Employee { EmployeeName = "Dung",Salary=2000, EnrollmentDate = DateTime.Parse("2003-09-01") },
                    new Employee { EmployeeName = "Hoa",Salary=2000, EnrollmentDate = DateTime.Parse("2002-09-01") },
                };
                foreach (Employee s in employees)
                {
                    context.Employees.Add(s);
                }
                context.SaveChanges();
                var departments = new Department[]
                {
                    new Department{ DepartmentID=1,Title="HR" },
                    new Department{ DepartmentID=2,Title="SC" },
                    new Department{ DepartmentID=3,Title="MD" },
                };
                foreach (Department c in departments)
                {
                    context.Departments.Add(c);
                }
                context.SaveChanges();
                var enrollments = new Enrollment[]
                {
                    new Enrollment{ EmployeeID=1,DepartmentID=1},
                    new Enrollment{ EmployeeID=2,DepartmentID=2},
                    new Enrollment{ EmployeeID=3,DepartmentID=3},
                    new Enrollment{ EmployeeID=4,DepartmentID=1},
                };
                foreach (Enrollment e in enrollments)
                {
                    context.Enrollments.Add(e);
                }
                context.SaveChanges();
            }
        }
    }
}
