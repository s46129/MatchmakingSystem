using System.Collections.Generic;

namespace MatchmakingSystem
{
    public interface IMatchmakingStrategy
    {
        List<Pair> Match(List<Individual> individuals);
    }
}