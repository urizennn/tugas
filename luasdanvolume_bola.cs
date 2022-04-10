using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Dan_Volume_Bola
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

            Console.WriteLine("\n\nProgram Mencari Luas Dan Volume Bola");
            double pi = 3.14, r;

            //INPUT
            Console.Write("Masukkan Jari-Jari Bola : ");
            r = Convert.ToDouble(Console.ReadLine());

            //PROSES
            double volume = pi * (r * r * r) * 4 / 3;
            double luas = 4 * pi * (r * r);

            //OUTPUT
            Console.WriteLine("\nLuas Bola   : " + luas);
            Console.WriteLine("Volume Bola : " + volume);
        }
    }
}
