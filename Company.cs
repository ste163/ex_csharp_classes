using System;
using System.Collections.Generic;

namespace ListExercise
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        public List<Employee> Employees { get; } = new List<Employee>();

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
        }

        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}