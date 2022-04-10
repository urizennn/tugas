using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_N_Integer_Pertama
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

            Console.WriteLine("\n\nTotal N Integer Pertama");
            int sum, n;

            //INPUT
            Console.Write("Masukkan Nilai N : ");
            n = Convert.ToInt32(Console.ReadLine());

            //PROSES
            sum = (n) * (n + 1) / 2;

            //OUTPUT
            Console.WriteLine("Total Dari N Integer Pertama : " + sum);
        }
    }
}
