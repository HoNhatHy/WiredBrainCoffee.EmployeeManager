using FluentValidation;

namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool IsDeveloper { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }

    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(emp => emp.FirstName)
            .NotEmpty().WithMessage("You must enter your first name")
            .MaximumLength(50).WithMessage("First name can not be longer than 50 characters");

            RuleFor(emp => emp.LastName)
            .NotEmpty().WithMessage("You must enter your last name")
            .MaximumLength(50).WithMessage("Last name can not be longer than 50 characters");

            RuleFor(emp => emp.DepartmentId)
                .NotEmpty().WithMessage("Please provide which department you work");
        }
    }
}
