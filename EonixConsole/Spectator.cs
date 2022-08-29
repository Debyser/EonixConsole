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
            if (trick == Trick.Music)
                Console.WriteLine(string.Format(_response, $"spectateur siffle pendant le tour de {trick.GetDescription()}", monkey.Number));
            else
                Console.WriteLine(string.Format(_response, $"spectateur applaudit pendant le tour d'{trick.GetDescription()}", monkey.Number));
        }
    }
}
