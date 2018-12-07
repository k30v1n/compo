using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.functionalities
{
    public class TextSender : ITextSender
    {
        public TextSender()
        {
            Console.WriteLine("TextSender was created.");
        }

        public void Text(string to) => Console.WriteLine($"Texted {to}.");
    }
}
