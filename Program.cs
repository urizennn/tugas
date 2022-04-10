using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konversi_Suhu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  : Nur Muhammad Akbar");
            Console.WriteLine("Kelas : TI.208");
            Console.WriteLine("Nim   : 20212205078");
            Console.WriteLine("\t\t\tI Make My Own Source Code Not From GOOGLE");
            Console.Write("\t\t\tPress Any Key To Start The Program.....");
            Console.ReadKey();
            //Celcius ke Fahrenheit
            //Fahrenheit ke Celcius
            //Reamur ke Celcius
            //Celcius ke Reamur
            //Kelvin ke Celcius
            //Celcius ke Kelvin

            Console.WriteLine("\n\nProgram Konversi Suhu");
            double celcius, farenheit, reamur, kelvin;
            double cf, fc, rc, cr, kc, ck;

            //INPUTAN SUHU
            Console.Write("Masukkan Suhu Celcius   : ");
            celcius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Suhu Farenheit : ");
            farenheit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Suhu Reamur    : ");
            reamur = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Suhu Kelvin    : ");
            kelvin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            //KONVERSI SUHU
            cf = celcius * 9 / 5 + 32;
            fc = farenheit - 32 * 5 / 9;
            rc = reamur * 5 / 4;
            cr = celcius * 4 / 5;
            kc = kelvin - 273.15;
            ck = celcius + 273.15;

            //OUTPUT
            Console.WriteLine("Celcius Ke Farenheit : " + cf);
            Console.WriteLine("Farenheit Ke Celcius : " + fc);
            Console.WriteLine("Reamur Ke Celcius    : " + rc);
            Console.WriteLine("Celcius Ke Reamur    : " + cr);
            Console.WriteLine("Kelvin Ke Celcius    : " + kc);
            Console.WriteLine("Celcius Ke Kelvin    : " + ck);

            Console.ReadKey();
        }
    }
}
