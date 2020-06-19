using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Assignment
{

    ///Club
        //Employee should be removed from Club Member List Only if Employee
            //Vacation Stock< 0.
            //If Employee Age> 60 will still remain a Member of Company Club
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }

        List<Employee> Members;

        public void AddMember(Employee E)
        {
            Members?.Add(E);
            Console.WriteLine($"Employee {E.EmployeeID } added to Club");
            E.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee)
            {
                employee.EmployeeLayOff -= RemoveMember;
                Members?.Remove(employee);
            }
            Console.WriteLine("Employee Removed from the Club");
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }

}
