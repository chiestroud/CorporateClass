using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = DateTime.Now;
        }
    }
}
