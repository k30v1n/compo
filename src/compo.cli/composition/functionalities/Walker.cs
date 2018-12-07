using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.functionalities
{
    public class Walker: IWalker
    {
        public Walker()
        {
            Console.WriteLine("Walker was created.");
        }

        public void Walk() => Console.WriteLine("walking.");
    }
}
