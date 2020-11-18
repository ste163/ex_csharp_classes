using System;
using ListExercise;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're running!");

            Employee Dan = new Employee("Dan", "Bland", "Baker");
            Employee Rhonda = new Employee("Rhonda", "Honda", "Manager");
            Employee Logan = new Employee("Logan", "Brogan", "Cashier");

            Company YummyBagels = new Company("Yummy Bagels");
            Console.WriteLine(YummyBagels.Name);
            YummyBagels.HireEmployee(Dan);
            YummyBagels.HireEmployee(Rhonda);
            YummyBagels.HireEmployee(Logan);

            YummyBagels.Employees.ForEach(employee => Console.Write($"{employee.FullName} "));
        }
    }
}
