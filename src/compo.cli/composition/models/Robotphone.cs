using System;
using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.models
{
    public class Robotphone
    {
        ICaller _caller;
        ITextSender _textSender;
        IWalker _walker;
        ISpeaker _speaker;

        public Robotphone(ICaller caller, ITextSender textSender, IWalker walker, ISpeaker speaker)
        {
            _caller = caller;
            _textSender = textSender;
            _walker = walker;
            _speaker = speaker;
        }

        public void Call(string to) => _caller.Call(to);

        public void Text(string to) => _textSender.Text(to);

        public void Walk() => _walker.Walk();

        public void Speak() => _speaker.Speak();
    }
}
