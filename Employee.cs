using System;

namespace ListExercise
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _title;
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
            _title = title;
            StartedOn = DateTime.Now;
        }
    }
}