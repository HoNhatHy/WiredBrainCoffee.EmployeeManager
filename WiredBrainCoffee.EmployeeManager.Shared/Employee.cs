namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool IsDeveloper { get; set; }
    }
}
