using Enonix.Domain.Model;
using Enonix.Domain.Model.Services;
using Eonix.Domain.Model;

namespace Eonix.Domain.Services
{
    public class SpectatorService : ISpectatorService
    {
        public SpectatorService()
        {
        }
        public string GetReactionByTrick(Trick trick)
        {
            return trick == Trick.Magic ? "spectateur applaudit pendant le tour de magie" : "spectateur applaudit pendant le tour d'acrobatie";
        }
    }
}
