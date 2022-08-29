namespace EonixConsole.Interfaces
{
    /// <summary>
    /// Easier to adapt to another langage
    /// </summary>
    public interface IObserver
    {
        void Update(ISubject subject, Trick trick);
    }
}
