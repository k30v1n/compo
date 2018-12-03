using System;
namespace compo.cli.hierarchy
{
    public class Person
    {
        public Person() => Console.WriteLine("person created");

        public void Live() => Console.WriteLine("I am living");

        public void Walk() => Console.WriteLine("walking.");

        public void Speak() => Console.WriteLine("speaking.");
    }
}
