using System;

namespace ListExercise
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        public string Title { get; }
        public DateTime StartedOn { get; }

        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }

        public Employee(string firstName, string lastName, string title)
        {
            _firstName = firstName;
            _lastName = lastName;
            Title = title;
            StartedOn = DateTime.Now;
        }
    }
}