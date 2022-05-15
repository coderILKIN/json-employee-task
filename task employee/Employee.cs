using System;
using System.Collections.Generic;
using System.Text;

namespace task_employee
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Employee(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }


       
    }
}
