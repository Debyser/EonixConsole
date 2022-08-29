
namespace EonixConsole
{
    public class Handler
    {
        private readonly Monkey _monkey;
        public Monkey Monkey => _monkey;

        public Handler(Monkey monkey)
        {
            _monkey = monkey;
        }
    }
}
