using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.functionalities
{
    public class Caller: ICaller
    {
        public Caller()
        {
            Console.WriteLine("Caller was created.");
        }

        public void Call(string to) => Console.WriteLine($"Called {to}.");
    }
}
