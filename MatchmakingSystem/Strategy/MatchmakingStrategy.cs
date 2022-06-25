using System.Collections.Generic;

namespace MatchmakingSystem.Strategy
{
    public interface IMatchmakingStrategy
    {
        List<Pair> Match(List<Individual> individuals);
    }
}