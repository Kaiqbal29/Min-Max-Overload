using prak5;
using System;
namespace prak5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write(" Masukan Nilai A : ");
            a = int.Parse(Console.ReadLine() );
            Console.Write(" Masukan Nilai B : ");
            b = int.Parse(Console.ReadLine() );
            Console.Write(" Masukan Nilai C : " );
            c = int.Parse(Console.ReadLine());

            Console.ReadLine();
            Number Nilai = new Number();
            Nilai.Min(a, b, c);
            Nilai.Max(a, b, c);
            Console.ReadKey();
        }
    }
}