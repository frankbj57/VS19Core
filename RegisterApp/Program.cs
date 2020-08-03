using System;
using RegisterLib;

namespace RegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new Register();

            register.AddItem(23.0);

            Console.WriteLine($"Antal items: {register.NItems}");
            Console.WriteLine($"Total: {register.Total}");

            var c = Console.ReadKey();
        }
    }
}
