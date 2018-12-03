using System;
namespace compo.cli.hierarchy
{
    public class Robotphone: Cellphone
    {
        Person _person;

        public Robotphone()
        {
            Console.WriteLine("robotphone created");
            _person = new Person();
        }

        public void Speak() => _person.Speak();

        public void Walk() => _person.Walk();
    }
}
