using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.functionalities
{
    public class Alive: IAlive
    {
        public Alive()
        {
            Console.WriteLine("Alive was created.");
        }

        public void Live() => Console.WriteLine("I am living");
    }
}
