using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Assignment
{
    
    enum LayOffCause
    { Retired , ExceedVacation  }

    //Company will Lay off All Type of Employees in Two Cases
        //If Employee Vacation Stock< 0
        //If Employee Age > 60

    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        int age;
        int vacationStock = 21;        
        DateTime bdate;
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get { return bdate; }
            set 
            {
                bdate = value;
                Age = (value - DateTime.Now).Days / 365 ;                
            }
        }
        public int VacationStock
        {
            get => vacationStock;
            set
            {
                if (value > vacationStock)
                {
                    vacationStock = 0;
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs()
                    { Cause = LayOffCause.ExceedVacation });
                }
                else
                    vacationStock = value < 0 ? vacationStock : value;
            }
        }
        public int Age 
        { 
            get => age;

            set
            {
                age = value;
                if (age > 60)
                    OnEmployeeLayOff
                        (new EmployeeLayOffEventArgs()
                        { Cause = LayOffCause.Retired });
            }
            
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            TimeSpan diff = To - From;
            int vacationrequested = diff.Days;
            if (vacationrequested < vacationStock)
            {
                VacationStock -= vacationrequested;
                Console.WriteLine("Employee took a Vacation ^_^");
                return true;
            }
            else 
            {
                VacationStock = vacationrequested;
                Console.WriteLine("Because Employee Exceed Vacation Stock");
                OnEmployeeLayOff(new EmployeeLayOffEventArgs()
                         { Cause = LayOffCause.ExceedVacation });
                return false;
            }
            
        }
        public void EndOfYearOperation()
        {
            age += 1;
            VacationStock = 21;
        }
    }


    public class EmployeeLayOffEventArgs : EventArgs
    {
        internal LayOffCause Cause { get; set; }
        internal int Quota { get; set; }
    }

    ///Sales Employee & Board Member
        //Sales Employee Doesn’t have Vacation Stock
        //Sales Employee Will not be Fired if his/her Vacation Stock<0
        //Sales Employee have a target to Achieve
        //Sales Employee will be Fired if Failed to Achieve Sales Target

        //Board Member has no retiring Age (will not be Fired if AGE > 60)
        //Board Member is not a Full time Employee(Has no vacation Stock)
        //Board Member will be layoff from the Company in case He/She Resigned.
        //Board Member will forever be a Member of Company Clubs
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            return Quota >= AchievedTarget;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            
            if (!CheckTarget(e.Quota))
                base.OnEmployeeLayOff(e);
            else if (Age > 60)
                base.OnEmployeeLayOff(e);
        }
    }

    class BoardMember : Employee
    {
        bool status = true;
        bool Status
        {
            get => status;
            set
            {
                status = value;
                if (!status)
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs()
                       { Cause = LayOffCause.Retired });
            }
        }
        public void Resign()
        {
            Status = false;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            
        }
    }

}
