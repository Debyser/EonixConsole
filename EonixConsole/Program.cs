using Enonix.Domain.Model;
using Enonix.Domain.Model.Services;
using Eonix.Domain.Services;
using System;
using Eonix.Domain.Model;
using System.Collections.Generic;
using System.Threading;

namespace EonixConsole
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject, Trick trick);
    }

    public interface ISubject
    {
        // Attach an observer to the subject.
        void Attach(IObserver observer);

        // Detach an observer from the subject.
        void Detach(IObserver observer);

        // Notify all observers about an event.
        void Notify(ISubject subject, Trick trick);
    }

    public class Monkey : ISubject
    {
        private int _number;
        private Trick[] _tricks;
        public int Number => _number;
        public Trick[] Tricks => _tricks;

        private List<IObserver> _observers = new List<IObserver>();

        public Monkey(int number, Trick[] tricks)
        {
            _number = number;
            _tricks = tricks;
        }

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
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

    class Spectator : IObserver
    {
        private static readonly string _response = @"{0} du singe {1}";

        public void Update(ISubject subject, Trick trick)
        {
            var monkey = subject as Monkey;
            if (monkey == null) return;
            if (trick == Trick.Magic)
                Console.WriteLine(string.Format(_response, "spectateur applaudit pendant le tour de magie du singe", monkey.Number));
            else
                Console.WriteLine(string.Format(_response, "spectateur applaudit pendant le tour d'acrobatie", monkey.Number));
        }
    }

    class Handler
    {
        private readonly Monkey _monkey;
        public Monkey Monkey => _monkey;

        public Handler(Monkey monkey)
        {
            _monkey = monkey;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var monkeyOne = new Monkey(1, new Trick[2] { Trick.Magic, Trick.Acrobatics });
            var handlerOne = new Handler(monkeyOne);

            var monkeyTwo = new Monkey(2, new Trick[2] { Trick.Acrobatics, Trick.Magic });
            var handlerTwo = new Handler(monkeyTwo);

            var observerSpectator = new Spectator();
            monkeyOne.Attach(observerSpectator);
            monkeyTwo.Attach(observerSpectator);

            //handlerOne.Monkey.ExecuteTricks(); // exécuter dresseur 1
            //handlerTwo.Monkey.ExecuteTricks(); // exécuter dresseur 2

            handlerOne.Monkey.ExecuteOneTrick(Trick.Magic); // exécuter dresseur 1
            //monkeyTwo.ExecuteTricks(); // exécuter dresseur 2

            monkeyOne.Detach(observerSpectator);
            monkeyTwo.Detach(observerSpectator);


        }
    }
}
