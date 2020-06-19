using System;
using System.Collections.Generic;

namespace Company_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Age = 30, EmployeeID = 1001 };

            DateTime date = DateTime.Now;
            date = date.AddDays(25);

            Department department1 = new Department() { DeptID = 101, DeptName = "SD" };

            department1.AddStaff(employee);

            Club club1 = new Club() { ClubID = 707, ClubName = "Intake 40" };

            club1.AddMember(employee);

            employee.RequestVacation(DateTime.Now, date);


        }
    }

       


   
       
    

}
