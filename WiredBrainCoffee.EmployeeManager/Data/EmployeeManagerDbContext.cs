using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data
{   
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData
            (
                new Department { Id = 1, Name = "Finance"},
                new Department { Id = 2, Name = "Sales"},
                new Department { Id = 3, Name = "Marketing"},
                new Department { Id = 4, Name = "Human Resources"},
                new Department { Id = 5, Name = "IT"}
            );

            modelBuilder.Entity<Employee>().HasData
            (
                new Employee { Id = 1, FirstName = "Hy", LastName = "Ho Nhat", DepartmentId = 5, IsDeveloper = true},
                new Employee { Id = 2, FirstName = "A", LastName = "Nguyen", DepartmentId = 1},
                new Employee { Id = 3, FirstName = "B", LastName = "Nguyen", DepartmentId = 1},
                new Employee { Id = 4, FirstName = "C", LastName = "Nguyen", DepartmentId = 2},
                new Employee { Id = 5, FirstName = "D", LastName = "Nguyen", DepartmentId = 3},
                new Employee { Id = 6, FirstName = "E", LastName = "Nguyen", DepartmentId = 4},
                new Employee { Id = 7, FirstName = "F", LastName = "Nguyen", DepartmentId = 4},
                new Employee { Id = 8, FirstName = "G", LastName = "Nguyen", DepartmentId = 4},
                new Employee { Id = 9, FirstName = "H", LastName = "Nguyen", DepartmentId = 5, IsDeveloper = true},
                new Employee { Id = 10, FirstName = "I", LastName = "Nguyen", DepartmentId = 2},
                new Employee { Id = 11, FirstName = "K", LastName = "Nguyen", DepartmentId = 2},
                new Employee { Id = 12, FirstName = "L", LastName = "Nguyen", DepartmentId = 1}
            );
        }
    }
}
