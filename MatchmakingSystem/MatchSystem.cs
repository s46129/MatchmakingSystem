using System.Collections.Generic;

namespace MatchmakingSystem
{
    public class MatchSystem
    {
        private List<Individual> _individuals;
        private MatchmakingStrategy _matchmakingStrategy;

        public MatchSystem(List<Individual> individuals, MatchmakingStrategy matchmakingStrategy)
        {
            _individuals = individuals;
            this._matchmakingStrategy = matchmakingStrategy;
        }
    }
}