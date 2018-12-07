using compo.cli.composition.functionalities.contracts;

namespace compo.cli.composition.models
{
    public class Cellphone
    {
        ICaller _caller;
        ITextSender _textSender;

        public Cellphone(ICaller caller, ITextSender textSender)
        {
            _caller = caller;
            _textSender = textSender;
        }

        public void Call(string to) => _caller.Call(to);

        public void Text(string to) => _textSender.Text(to);
    }
}
