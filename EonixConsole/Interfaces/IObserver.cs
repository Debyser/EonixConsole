namespace EonixConsole.Interfaces
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject, Trick trick);
    }
}
