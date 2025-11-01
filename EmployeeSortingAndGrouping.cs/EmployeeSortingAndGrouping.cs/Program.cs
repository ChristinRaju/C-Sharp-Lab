using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSortingAndGrouping
{
    // Define Employee class
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample employee data
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 65000 },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 55000 },
                new Employee { Id = 4, Name = "David", Department = "IT", Salary = 70000 },
                new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 52000 },
                new Employee { Id = 6, Name = "Frank", Department = "Finance", Salary = 48000 }
            };

            // ---- Sorting Employees by Salary (Descending) ----
            var sortedEmployees = from emp in employees
                                  orderby emp.Salary descending
                                  select emp;

            Console.WriteLine("Employees Sorted by Salary (Descending):");
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"{emp.Name,-10} | {emp.Department,-10} | ${emp.Salary}");
            }

            Console.WriteLine("\n-------------------------------------\n");

            // ---- Grouping Employees by Department ----
            var groupedEmployees = from emp in employees
                                   group emp by emp.Department into deptGroup
                                   orderby deptGroup.Key
                                   select deptGroup;

            Console.WriteLine("Employees Grouped by Department:");
            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");
                foreach (var emp in group)
                {
                    Console.WriteLine($"  - {emp.Name} (${emp.Salary})");
                }
            }

            Console.ReadLine();
        }
    }
}
