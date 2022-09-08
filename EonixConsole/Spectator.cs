using System;

namespace EonixConsole
{
    public static class Spectator
    {
        private static readonly string _response = @"{0} du singe {1}";
        // event handler
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            if (e.Trick == Trick.Music)
                Console.WriteLine(string.Format(_response, $"spectateur siffle pendant le tour de {e.Trick.GetDescription()}", e.Number));
            else
                Console.WriteLine(string.Format(_response, $"spectateur applaudit pendant le tour d'{e.Trick.GetDescription()}", e.Number));
        }
    }
}
