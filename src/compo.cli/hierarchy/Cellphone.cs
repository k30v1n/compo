using System;
namespace compo.cli.hierarchy
{
    public class Cellphone
    {
        public Cellphone() => Console.WriteLine("cellphone created");

        public void Call(string to) => Console.WriteLine($"Called {to}.");

        public void Text(string to) => Console.WriteLine($"Texted {to}.");
    }
}
