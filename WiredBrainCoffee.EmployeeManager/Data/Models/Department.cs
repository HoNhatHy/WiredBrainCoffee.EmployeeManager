using FluentValidation;

namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(department => department.Name)
                .NotEmpty().WithMessage("You must enter the department name");
        }
    }
}
