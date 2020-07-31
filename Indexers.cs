using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasic
{
    public  class Employee23
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
    }

    public class Company23
    {
        List<Employee23> listEmp;
       
        public Company23()
        {
            listEmp = new List<Employee23>();
            listEmp.Add(new Employee23 { EmployeeID = 1, Name = "Mike", Gender = "Male" });
            listEmp.Add(new Employee23 { EmployeeID = 2, Name = "John", Gender = "Male" });
            listEmp.Add(new Employee23 { EmployeeID = 3, Name = "Raine", Gender = "Female" });
            listEmp.Add(new Employee23 { EmployeeID = 4, Name = "Ben", Gender = "Female" });
            listEmp.Add(new Employee23 { EmployeeID = 5, Name = "Todd", Gender = "Male" });
            listEmp.Add(new Employee23 { EmployeeID = 6, Name = "Maxine", Gender = "Female" });
            listEmp.Add(new Employee23 { EmployeeID = 7, Name = "Emiliy", Gender = "Female" });
            listEmp.Add(new Employee23 { EmployeeID = 8, Name = "Mell", Gender = "Female" });
        }
      
        public string this[int empID]
        {
            get
            {
                return listEmp.FirstOrDefault(emp => emp.EmployeeID == empID).Name;
            }
            set
            {
                listEmp.FirstOrDefault(emp => emp.EmployeeID == empID).Name = value;
            }
        }
    }
}
