using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of employee salaries
        List<double> salaries = new List<double> { 45000, 52000, 60000, 48000, 75000, 50000, 51000 };

        // Use a lambda expression to filter salaries > 50000
        var highSalaries = salaries.Where(salary => salary > 50000);

        Console.WriteLine("Salaries above 50,000:");

        // Display the filtered salaries
        foreach (var salary in highSalaries)
        {
            Console.WriteLine(salary);
        }
    }
}
