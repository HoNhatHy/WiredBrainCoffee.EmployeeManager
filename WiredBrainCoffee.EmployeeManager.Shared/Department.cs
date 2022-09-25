﻿namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
