using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDepartmentJoin
{
    // Define Department class
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    // Define Student class
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int DeptId { get; set; } // Foreign key linking to Department
    }

    class Program
    {
        static void Main()
        {
            // Enable UTF-8 for any special characters
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Create a list of departments
            List<Department> departments = new List<Department>
            {
                new Department { DeptId = 1, DeptName = "Computer Science" },
                new Department { DeptId = 2, DeptName = "Information Technology" },
                new Department { DeptId = 3, DeptName = "Electronics" }
            };

            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 101, StudentName = "Emma", DeptId = 1 },
                new Student { StudentId = 102, StudentName = "Ethan", DeptId = 2 },
                new Student { StudentId = 103, StudentName = "Liam", DeptId = 1 },
                new Student { StudentId = 104, StudentName = "Noah", DeptId = 3 },
                new Student { StudentId = 105, StudentName = "Olivia", DeptId = 2 }
            };

            // LINQ Join: Combine students with their departments
            var studentDeptJoin = from s in students
                                  join d in departments
                                  on s.DeptId equals d.DeptId
                                  select new
                                  {
                                      StudentName = s.StudentName,
                                      DepartmentName = d.DeptName
                                  };

            // Display results
            Console.WriteLine("----- Student and Department List -----");
            foreach (var item in studentDeptJoin)
            {
                Console.WriteLine($"{item.StudentName,-10} | {item.DepartmentName}");
            }
        }
    }
}
