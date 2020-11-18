using System;

namespace ListExercise
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
        }
    }
}