using Enonix.Domain.Model;
using Enonix.Domain.Model.Services;
using Eonix.Domain.Model;
using System;
using System.Text;

namespace Eonix.Domain.Services
{
    public class MonkeyService : IMonkeyService
    {
        private readonly ISpectatorService _spectatorService;
        public MonkeyService(ISpectatorService spectatorService)
        {
            _spectatorService = spectatorService;
        }
        public void Execute(Monkey monkey)
        {
            if (monkey.Tricks == null || monkey.Tricks.Length == 0) return;
            var count = monkey.Tricks.Length;
            var tricks = monkey.Tricks;
            StringBuilder stringBuilder = new StringBuilder();
            for (var i = 0; i < count; ++i)
            {
                var trick = tricks[i];
                stringBuilder.Append(_spectatorService.GetReactionByTrick(trick));
                if (trick == Trick.Magic)
                    stringBuilder.Append(string.Format("{0} du singe {1}", "faire disparaître la balle", monkey.Number));
                else
                    stringBuilder.Append(string.Format("{0} du singe {1}", "marcher sur les mains", monkey.Number));
            }
        }
    }
}
