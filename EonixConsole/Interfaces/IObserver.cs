namespace EonixConsole.Interfaces
{
    public interface IObserver
    {
        void Update(ISubject subject, Trick trick);
    }
}
