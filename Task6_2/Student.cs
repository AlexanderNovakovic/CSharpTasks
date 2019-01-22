using System;

namespace Task6_2
{
    public class Student : Person
    {
        public string School { get; }
        public string Grade { get; }

        public Student(string name, DateTime dateOfBirth, string address, string school, string grade) 
            : base(name, dateOfBirth, address)
        {
            School = school;
            Grade = grade;
        }
    }
}
