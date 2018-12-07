using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.models
{
    public class Person
    {
        IWalker _walker;
        ISpeaker _speaker;
        IAlive _alive;

        public Person(IWalker walker, ISpeaker speaker, IAlive alive)
        {
            _walker = walker;
            _speaker = speaker;
            _alive = alive;
        }

        public void Walk() => _walker.Walk();

        public void Speak() => _speaker.Speak();

        public void Alive() => _alive.Live();
    }
}
