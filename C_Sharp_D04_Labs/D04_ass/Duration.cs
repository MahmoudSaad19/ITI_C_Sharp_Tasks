using System;
using System.Collections.Generic;
using System.Text;

namespace D04_ass
{
    class Duration 
    {
        ///Define Class Duration
        ///To include Three Attributes(Hours, Minutes, Seconds)

        int _hours, _minutes, _seconds;

        //Support All Required Constructors to Produce this output

        ///Duration D1 = new Duration(1, 10, 15);
        ///D.ToString(); 
        ///Output: Hours: 1, Minutes :10 , Seconds :15

        public Duration(int hours, int minutes, int seconds)
        {
            _hours = hours>23 || hours <= 0 ? 0  : hours ;
            _minutes = minutes>59 || minutes <= 0 ? 0 : minutes;
            _seconds = seconds > 59 || seconds <= 0 ? 0 : seconds;
        }

        ///Duration D1 = new Duration(3600);
        ///D.ToString(); 
        ///Output: Hours: 1, Minutes :0 , Seconds :0
        ///
        ///Duration D2 = new Duration(7800);
        ///D.ToString(); 
        ///Output: Hours: 2, Minutes :10 , Seconds :0

        ///Duration D3 = new Duration(666);
        ///D.ToString(); 
        ///Output: Minutes :11 , Seconds :6
        ///
        public Duration(int seconds)
        {
            if (seconds < 0)
                _seconds = _minutes = _hours = 0;
            else
            {
                // ex input 3700
                int temp = seconds % 3600; // 100= 3700%3600
                _hours = seconds / 3600; // 1=3700/3600
                _minutes = temp/60; // 1=100/60
                temp = temp % 60; // 40= 100%60
                _seconds = temp; //40
            }            
        }

        ///Override All System.Object Members(ToString, Equals, GetHasCode) .
        ///Override Equals to Work as Value Equality

        public override bool Equals(object obj)
        {
            return obj is Duration right &&
                   _hours == right._hours &&
                   _minutes == right._minutes &&
                   _seconds == right._seconds;
        }

       /* public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/

        //Output from ToString Should follow this pattern
        //Hours: 1, Minutes :30, Seconds :20
        public override string ToString()
        {
            if (_hours ==0 && _minutes ==0)
                return $"Seconds : {_seconds} s";
            else if (_hours == 0)
                return $"Minutes : {_minutes}, Seconds : {_seconds} s ";
            return $"Hours: {_hours}, Minutes : {_minutes}, Seconds : {_seconds} s";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_hours, _minutes, _seconds);
        }

        ///Implement All required Operators overloading’s to enable this Code

        ///D3=D1+D2
        ///

        public static Duration operator +(Duration Left, Duration Right)
        {
            int t = 0 , r =0;
            int s = Left._seconds + Right._seconds > 59 ? t++ : Left._seconds + Right._seconds;
            t += Left._minutes + Right._minutes > 59 ? r++ : Left._minutes + Right._minutes;
            r += Left._hours + Right._hours;
            return new Duration(r,t,s);
        }

        ///D3 = D1 + 7800
        ///

        public static Duration operator +(Duration Left, int Right)
        {
            int t = Left._minutes *60 , r = Left._hours * 3600;
            int s = t+r + Right;            
            return new Duration(s);
        }

        ///D3=666+D3
        ///

        public static Duration operator +(int Left, Duration Right)
        {
            int t = Right._minutes * 60 , r = Right._hours *3600;
            int s = t + r + Left;
            return new Duration(s);
        }

        ///D3 = D1++(Increase One Minute)
        ///

        public static Duration operator ++(Duration d)
        {
            int r = 0;
            int t = (d._minutes+1) > 59 ? r++ : d._minutes +1;
            r += d._hours;
            return new Duration(r, t, d._seconds);
        }

        ///D3 =--D2; (Decrease One Minute)
        ///

        public static Duration operator --(Duration d)
        {            
            return new Duration(d._hours,d._minutes - 1,d._seconds);
        }

        ///D1 -=D2;
        ///      
        public static Duration operator -(Duration Left, Duration Right)
        {            
            return new Duration(
                Left._hours-Right._hours ,
                Left._minutes - Right._minutes ,
                Left._seconds - Right._seconds
                );
        }

        ///If(D1>D2);
        ///

        public static bool operator > (Duration Left, Duration Right)
        {
            if (Left._hours == Right._hours && Left._minutes == Right._minutes)
                return Left._seconds > Right._seconds;
            else if (Left._hours == Right._hours)
                return Left._minutes > Right._minutes;
            return Left._hours > Right._hours;
        }
        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left._hours == Right._hours && Left._minutes == Right._minutes)
                return Left._seconds < Right._seconds;
            else if (Left._hours == Right._hours)
                return Left._minutes < Right._minutes;
            return Left._hours < Right._hours;
        }

        ///If(D1<=D2);
        ///

        public static bool operator >=(Duration Left, Duration Right)
        {
            if (Left._hours == Right._hours && Left._minutes == Right._minutes)
                return Left._seconds >= Right._seconds;
            else if (Left._hours == Right._hours)
                return Left._minutes >= Right._minutes;
            return Left._hours >= Right._hours;
        }
        public static bool operator <=(Duration Left, Duration Right)
        {
            if (Left._hours == Right._hours && Left._minutes == Right._minutes)
                return Left._seconds <= Right._seconds;
            else if (Left._hours == Right._hours)
                return Left._minutes <= Right._minutes;
            return Left._hours <= Right._hours;
        }

        ///If(D1)
        ///
        
        public static implicit operator bool(Duration d)
        {
            return d._hours != 0 && d._minutes !=0 && d._seconds != 0;
        }
        

        ///DateTime Obj = (DateTime)D1

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2020,1,2,d._hours,d._minutes,d._seconds);            
        }
        





    }
}
