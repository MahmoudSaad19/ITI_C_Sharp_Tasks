using System;

namespace D03_assignment
{
    class Program
    {

        static void Main(string[] args)
        {          
            int id=0 , date = 1;
            decimal sal = 1;
            Gender g= Gender.M;
            bool w ;
            SecurityLevel sec = SecurityLevel.Developer;
            Employee[] employees = new Employee[3];
            for (int i=0; i<3; i++)
            {
                Console.WriteLine($"Enter Employee No {i+1} data : \n");
                do
                {
                    Console.WriteLine("Enter Employee id : ");
                } while ((!int.TryParse(Console.ReadLine(), out id)) || (id <= 0));
                do
                {
                    Console.WriteLine("Enter Employee Gender : ");
                    bool c = Enum.TryParse(Console.ReadLine(), out g);
                    w = true;
                    if (c)
                    {
                        int t = -1;
                        t = (int)g;
                        w = !(t == 0 || t == 1);
                    }                       

                } while (w);
                do
                {
                    Console.WriteLine("Enter Employee Salary : ");
                } while (!decimal.TryParse(Console.ReadLine(), out sal) || sal <= 0);
                do
                {
                    Console.WriteLine("Enter Employee Security Level : ");
                } while (!Enum.TryParse(Console.ReadLine(), out sec));
                do
                {
                    Console.WriteLine("Enter Employee hire day : ");
                } while ((!int.TryParse(Console.ReadLine(), out date)) || (date <= 0) || (date > 31));

                //Console.WriteLine($" Gender is  {g}");
                //Console.WriteLine($" Gender int  is  {(int)g}");

                employees[i] = new Employee(id, sal, sec, new HireDate(date), g);
            }



            //DBA, Guest and the third one is security officer
            Employee e = new Employee(id, sal, sec, new HireDate(10), g);
            Employee e1 = new Employee(10, 1000, SecurityLevel.Developer, new HireDate(10), 0);
            Employee e2 = new Employee(10, 1000, SecurityLevel.Developer, new HireDate(10), 0);

            //foreach (var i in employees)
            //    Console.WriteLine(i);

            //Console.WriteLine();
            //Console.WriteLine("After Sort : ");
            //Console.WriteLine();

            //Array.Sort(employees);
            //foreach (var i in employees)
            //    Console.WriteLine(i);

            //Console.WriteLine();


        }

    
    }

    struct Employee : IComparable
    {
        int ID;
        decimal salary;
        SecurityLevel securityLevel ;
        HireDate hireDate;
        Gender gender ;

        public Employee(int iD, decimal _salary , SecurityLevel _securityLevel,
            HireDate _hireDate , Gender _gender = Gender.M )
        {
            ID = iD;
            salary = _salary;
            securityLevel = _securityLevel;
            hireDate = _hireDate;
            gender = _gender;
        }

        public int CompareTo(object obj)
        {
            Employee employee = (Employee)obj;
            return hireDate.CompareTo(employee.hireDate);
        }

        public void setGender (string text)
        {
            if (text.ToLower() == "female")
                text = "Female";
            else
                text = "Male";
            gender = (Gender) Enum.Parse(typeof(Gender), text);

        }

        public override string ToString()
        {
            string str = String.Format("Employee with ID :{0} {1} " +
                "\nSalary = {2:C} \nSecurity Level : {3} \nHire Date : {4} "
                , ID ,gender,salary,securityLevel,hireDate);
            return str;
        }
    }

    struct HireDate : IComparable
    {
        int Day;
        int _month;
        int _year;

        public HireDate(int day = 1, int month = 1, int year = 2020)
        {
            Day = day;
            _month = month;
            _year = year;
        }

        public int CompareTo(object obj)
        {
            HireDate date = (HireDate)obj;
            int flag = _year.CompareTo(date._year);
            if ( flag == 0)
                flag = _month.CompareTo(date._month);
            if (flag == 0)
                flag = Day.CompareTo(date.Day);
            return flag;
        }

        public override string ToString()
        {
            string text = String.Format(" {0}/{1}/{2} ",Day,_month,_year);
            return text;
        }

    }
    
    [Flags]
    enum SecurityLevel : byte
    {
        guest = 1, Developer = 2, secretary = 4 , DBA = 8 , securityofficer = 15
    }

    enum Gender : byte
    {
         M = 0 , F = 1
    }


  }
