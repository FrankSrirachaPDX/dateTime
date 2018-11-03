using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime =  DateTime.Now;
            int hours;

            Console.WriteLine(dateTime);
            Console.WriteLine("Enter a number!");
            hours = Convert.ToInt32(Console.ReadLine());
            dateTime = dateTime.AddHours(hours);
            Console.WriteLine(dateTime);
            Console.ReadLine();
        }
    }
}
