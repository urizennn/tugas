using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uit_Of_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  : Nur Muhammad Akbar");
            Console.WriteLine("Kelas : TI.208");
            Console.WriteLine("Nim   : 20212205078");
            Console.WriteLine("\t\t\tI Make My Own Source Code Not From GOOGLE");
            Console.Write("\t\t\tPress Any Key To See The Program.....");
            Console.ReadKey();

            
            Console.WriteLine("\n\nProgram Unit Of Time");

            //INPUT
            Console.Write("Day(s)     : ");
            var dayy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hour(s)    : ");
            var hourr = Convert.ToDouble(Console.ReadLine());
            Console.Write("Minute(s)  : ");
            var minutee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second(s)  : ");
            var secondd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=============================================\n");

            //PROSES
            var day = dayy * 86400;
            var hour = hourr * 3600;
            var minute = minutee * 60;
            double equal = day + hour + minute + secondd;

            //OUTPUT
            Console.WriteLine("Day(s)    : " + dayy);
            Console.WriteLine("Hour(s)   : " + hourr);
            Console.WriteLine("Minute(s) : " + minutee);
            Console.WriteLine("Second(s) : " + secondd);
            Console.WriteLine("Equal To  : " + equal + " second\n");
            Console.ReadKey();
        }
    }
}
