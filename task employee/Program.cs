using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace task_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ilkin", "Yusubov", 21);
            Employee employee2 = new Employee("Ilkin", "Yusubov", 24);
            Employee employee3 = new Employee("Ilkin", "Yusubov", 23);
            Employee employee4 = new Employee("Ilkin", "Yusubov", 22);

            List<Employee> Employees = new List<Employee>();
            Employees.Add(employee);
            Employees.Add(employee2);
            Employees.Add(employee3);
            Employees.Add(employee4);

            string json = JsonConvert.SerializeObject(Employees);

            Console.WriteLine(json);


            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\tu758403c\source\repos\task employee\task employee\json1.json"))
            {
                streamWriter.Write(json);
            }

            string result;

            using (StreamReader streamReader  =new StreamReader(@"C:\Users\tu758403c\source\repos\task employee\task employee\json1.json"))
            {
                result = streamReader.ReadLine();
            }

            var des = JsonConvert.DeserializeObject(result);
            Console.WriteLine(des);
        }
    }
}
