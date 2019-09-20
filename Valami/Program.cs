using System;

namespace Valami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, hogy hívnak?");
            var v = Console.ReadLine();
            Console.WriteLine($"Milyen szép neved van {v}");
            Console.WriteLine("Szeretsz programozni?");
            v = Console.ReadLine();
            if (v == "igen")
                Console.WriteLine("jaj de jó");
            else
                Console.WriteLine("Nem jó");

            Console.ReadKey();
        }
    }
}
