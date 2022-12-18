using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExamEmployee.Data;
using System;
using System.Linq;
namespace ExamEmployee.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamEmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ExamEmployeeContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }
                context.Employee.AddRange(
                    new Employee
                    {
                        Title = "Huy",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Derpartment = "HR",
                        Salary = 7.99M
                    },
                    new Employee
                    {
                        Title = "Ha",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Derpartment = "SC",
                        Salary = 7.99M
                    },
                    new Employee
                    {
                        Title = "Hai",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Derpartment = "MD",
                        Salary = 7.99M
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
