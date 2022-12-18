using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    
        public class EmployeeContext : DbContext
        {
            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
            {
            }

            public DbSet<Department> Departments { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
    
}
