using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static void doApp()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDate);

            DateTime specificDate = new DateTime(2023, 10, 15);
            Console.WriteLine("Specific Date: " + specificDate);

            DateTime dt = DateTime.Now; 
            Console.WriteLine("Formatted custom date strings: ");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("y"));

            Console.WriteLine("Adding 5 days to today: " + dt.AddDays(5).ToShortDateString());


            int year = 2024;
            bool isLeapYear = DateTime.IsLeapYear(year);
            Console.WriteLine(year + " is a leap year: " + isLeapYear);

            DateTime date1 = new DateTime(2023, 6, 2, 12, 2, 16);
            DateTime date2 = new DateTime(2023, 6, 12, 14, 6, 16);

            TimeSpan value = date1.Subtract(date2);

            Console.WriteLine("TimeSpan between two dates is " + value.Hours + " hours");


        }
    }
}
