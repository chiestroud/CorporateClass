using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var chieCompany = new Company("Chie Corporation", DateTime.Today);
            Console.WriteLine($"{chieCompany.Name} was established in {chieCompany.CreatedOn}");
            Console.WriteLine($"Here is the list of employees in {chieCompany.Name}");

            chieCompany.addEmployee("Chie Stroud", "President");
            chieCompany.addEmployee("Chie Stro", "Normal Office Worker");
            chieCompany.addEmployee("Che Sro", "Window Cleaner");
            chieCompany.addEmployee("Chi Stroud", "Vice President");
            chieCompany.addEmployee("John", "Vice President");

            chieCompany.removeEmployee("John");

            chieCompany.retrieveEmployeeList();
        }
    }
}
