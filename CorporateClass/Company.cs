using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get;  }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> employeeList { get; set; } = new List<Employee>();
        
        // Create a method that allows a caller to add an employee
        public void addEmployee(string employeeName, string jobTitle)
        {
            employeeList.Add(new Employee(employeeName, jobTitle));
        }
        // Create a method that allows a caller to remove an employee
        public void removeEmployee(string employeeName)
        {
            employeeList.RemoveAll(s => s.Name == employeeName);
        }
        // Create a method that allows a caller to retrieve the list of employees
        public void retrieveEmployeeList()
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"Name: {employee.Name}, Job Title: {employee.JobTitle}, Start Date: {employee.StartDate.ToString("dd/MM/yyyy")}");
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
    }
}
