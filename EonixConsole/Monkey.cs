using EonixConsole.Interfaces;
using System;
using System.Collections.Generic;

namespace EonixConsole
{
    public class Monkey : ISubject
    {
        private int _number;
        private Trick[] _tricks;
        private List<IObserver> _observers = new List<IObserver>();

        public int Number => _number;
        public Trick[] Tricks => _tricks;


        public Monkey(int number, Trick[] tricks)
        {
            _number = number;
            _tricks = tricks;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ExecuteTricks()
        {
            if (_tricks == null || _tricks.Length == 0) return;
            var count = _tricks.Length;
            for (var i = 0; i < count; ++i)
                Notify(this, _tricks[i]);
        }

        public void ExecuteOneTrick(Trick trick)
        {
            if (_tricks == null || _tricks.Length == 0) return;
            var count = _tricks.Length;
            for (var i = 0; i < count; ++i)
            {
                var currentTrick = _tricks[i];
                if (currentTrick != trick) continue;
                Notify(this, _tricks[i]);
            }
        }

        public void Notify(Trick trick) => throw new NotImplementedException();

        public void Notify(ISubject subject, Trick trick)
        {
            foreach (var observer in _observers)
                observer.Update(this, trick);
        }
    }
}
