using System;

namespace EonixConsole
{
    public class Monkey //: ISubject
    {
        private int _number;
        private Trick[] _tricks;

        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public int Number => _number;
        public Trick[] Tricks => _tricks;

        public Monkey(int number, Trick[] tricks)
        {
            _number = number;
            _tricks = tricks;
        }

        public void ExecuteTricks()
        {
            var data = new ProcessEventArgs();
            if (_tricks == null || _tricks.Length == 0) return;
            var count = _tricks.Length;

            Console.WriteLine("Process Started!");
            for (var i = 0; i < count; ++i)
            {
                data.Trick = _tricks[i];
                data.Number = this.Number;
                OnProcessCompleted(data);
            }
        }

        public void ExecuteOneTrick(Trick trick)
        {
            var data = new ProcessEventArgs();
            if (_tricks == null || _tricks.Length == 0) return;
            var count = _tricks.Length;
            for (var i = 0; i < count; ++i)
            {
                var currentTrick = _tricks[i];
                if (currentTrick != trick) continue;
                data.Trick = _tricks[i];
                data.Number = this.Number;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e) => ProcessCompleted?.Invoke(this, e);
    }
}
