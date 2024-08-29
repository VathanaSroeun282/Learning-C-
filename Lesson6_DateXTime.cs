using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLerningEvening
{
    public class Lesson6_DateXTime
    {
        private void Example1()
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime(2015, 12, 31);
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 30);
            DateTime dt4 = new DateTime(2023, 10, 26, 2,30, 40, DateTimeKind.Utc);
            Console.WriteLine("Date and time now : " + dt1 + dt2 + dt3 + dt4);
        }
        private void Example2()
        {
            DateTime myTime = new DateTime(2015, 12, 10);

            DateTime dt = new DateTime(636370000);
            //DateTime.MinValue.Ticks;
            //DateTime.MinValue.Ticks;
        }
        private void Example3()
        {
            DateTime dt = new DateTime(2015, 12, 31);
            TimeSpan newTimeSpan = new TimeSpan(10, 20, 40);
            DateTime newDate = dt.Add(newTimeSpan);
            Console.WriteLine("Your new date is : " + newDate);
        }
        private void Example4()
        {
            Console.WriteLine("---------Example 4---------");
            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            DateTime maxDateTimeValue = DateTime.MaxValue;
            DateTime minDateTimeValue = DateTime.MinValue;
            Console.WriteLine($"Current Date Time is : {currentDateTime}");
            Console.WriteLine($"Today Date Time is   : {todaysDate}");
            Console.WriteLine($"Current Date Time UTC: {currentDateTimeUTC}");
            Console.WriteLine($"Max Date Time Value  : {maxDateTimeValue}");
            Console.WriteLine($"Min Date Time Value  : {minDateTimeValue}");
        }
        private void Example5()
        {
            Console.WriteLine("-----Example5-----");
            DateTime t1 = new DateTime(2015, 12, 20);
            DateTime t2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);
            Console.WriteLine(t2 + time);
            Console.WriteLine(t2-t1);
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 >= t2);
            Console.WriteLine(t1 <= t2);
            Console.WriteLine(t1 < t2);
            Console.WriteLine(t1 > t2);

        }
        public Lesson6_DateXTime() {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
        }
    }
}
