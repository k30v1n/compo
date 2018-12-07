using System;
using compo.cli.composition.functionalities;
using compo.cli.composition.functionalities.contracts;

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

            ICaller caller = new Caller();
            ISpeaker speaker = new Speaker();
            ITextSender text = new TextSender();
            IWalker walker = new Walker();
            var robot2 = new composition.models.Robotphone(caller, text, walker, speaker);
            robot2.Walk();
            robot2.Speak();
            robot2.Call("222-222");
            robot2.Text("222-222");

            Console.ReadKey();
        }
    }
}
