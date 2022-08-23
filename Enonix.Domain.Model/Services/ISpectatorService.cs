using Eonix.Domain.Model;
using System.Collections.Generic;

namespace Enonix.Domain.Model.Services
{
    public interface ISpectatorService
    {
        string GetReactionByTrick(Trick trick);
    }
}
