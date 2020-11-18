using System;
using ListExercise;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Dan = new Employee("Dan", "Bland", "Baker");
            Employee Rhonda = new Employee("Rhonda", "Honda", "Manager");
            Employee Logan = new Employee("Logan", "Brogan", "Cashier");

            Company YummyBagels = new Company("Yummy Bagels");

            YummyBagels.HireEmployee(Dan);
            YummyBagels.HireEmployee(Rhonda);
            YummyBagels.HireEmployee(Logan);

            YummyBagels.Employees.ForEach(employee => Console.WriteLine($"{employee.FullName} works for {YummyBagels.Name} as {employee.Title} since {employee.StartedOn}."));
        }
    }
}
