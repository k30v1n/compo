using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.functionalities
{
    public class Speaker : ISpeaker
    {
        public Speaker()
        {
            Console.WriteLine("Speaker was created.");
        }

        public void Speak() => Console.WriteLine("speaking.");
    }
}
