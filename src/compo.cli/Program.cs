using System;

namespace compo.cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Robotphone 1...");
            Console.WriteLine();
            var robot1 = new hierarchy.Robotphone();

            robot1.Walk();
            robot1.Speak();
            robot1.Call("111-111");
            robot1.Text("111-111");
            Console.WriteLine();

            Console.WriteLine("Testing Robotphone 2...");

            //TODO: composition

            Console.ReadKey();
        }
    }
}
