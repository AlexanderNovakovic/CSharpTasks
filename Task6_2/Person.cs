using System;

namespace Task6_2
{
    public class Person
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public string Address { get; }

        public Person(string name, DateTime dateOfBirth, string address)
        {
            if (name == null || dateOfBirth == null || address == null)
            {
                throw new ArgumentException();
            }

            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
        }
    }
}
