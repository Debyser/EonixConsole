namespace EonixConsole.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(ISubject subject, Trick trick);
    }
}