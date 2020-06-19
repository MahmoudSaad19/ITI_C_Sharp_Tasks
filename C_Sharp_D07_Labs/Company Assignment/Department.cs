using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Assignment
{

    ///Department
        //Employee should be removed from Department Staff List in both Cases
            //If Employee Vacation Stock< 0
            //If Employee Age > 60
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            Staff?.Add(E);
            Console.WriteLine($"Employee {E.EmployeeID } added to Department {DeptName}");
            E.EmployeeLayOff += RemoveStaff;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee)
            {
                employee.EmployeeLayOff -= RemoveStaff;
                Staff?.Remove(employee);
            }
            Console.WriteLine("Employee Removed from the Department");
        }
    }

}
