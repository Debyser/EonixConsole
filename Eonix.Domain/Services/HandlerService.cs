using Enonix.Domain.Model;
using Enonix.Domain.Model.Services;
using Eonix.Domain.Model;

namespace Eonix.Domain.Services
{
    public class HandlerService : IMonkeyService
    {
        private readonly IMonkeyService _monkey;
        public HandlerService(IMonkeyService monkey)
        {
            _monkey = monkey;
        }

        //public void Ask(Monkey monkey)
        //{
        //    _monkey.Execute(monkey);
        //}

        public void Execute(Monkey monkey)
        {
            _monkey.Execute(monkey);
        }

        public Trick GetTrick(Trick trick)
        {
            return trick;
        }
    }
}
