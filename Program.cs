using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akar_Persamaan_Kuadrat
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

            Console.WriteLine("\n\nProgram Akar Persasmaan Kuadrat");
            Console.WriteLine("A. 3x^2 + 4x + 3 = ");
            var akar5 = (-4 + Math.Sqrt(8 - 4 * 3 * 3)) / (2 * 3);
            Console.WriteLine("X1 = " + akar5);
            var akar6 = (-4 - Math.Sqrt(8 - 4 * 3 * 3)) / (2 * 3);
            Console.WriteLine("X2 = " + akar5 + "\n");


            Console.WriteLine("B. -x^2 - 7x + 12 = ");
            var akar3 = (7 + Math.Sqrt(49 - 4 * 1 * 12)) / -2;
            Console.WriteLine("X1 = " + akar3);
            var akar4 = (7 - Math.Sqrt(49 - 4 * 1 * 12)) / -2;
            Console.WriteLine("X2 = " + akar4 + "\n");


            Console.WriteLine("C. x^2 - 9x + 18 = ");
            var akar1 = (9 + Math.Sqrt(-9 * -9 - 4 * 18)) / 2;
            Console.WriteLine("X1 = " + akar1);
            var akar2 = (9 - Math.Sqrt(-9 * -9 - 4 * 18)) / 2;
            Console.WriteLine("X2 = " + akar2 + "\n");
        }
    }
}
