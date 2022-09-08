using System;

namespace EonixConsole
{
    public class ProcessEventArgs : EventArgs
    {
        public int Number { get; set; }
        public Trick Trick { get; set; }
    }
}