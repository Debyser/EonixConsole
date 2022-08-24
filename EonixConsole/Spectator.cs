using EonixConsole.Interfaces;
using System;

namespace EonixConsole
{
    public class Spectator : IObserver
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
}
