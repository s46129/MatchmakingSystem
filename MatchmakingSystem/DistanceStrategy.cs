using System.Collections.Generic;

namespace MatchmakingSystem
{
    public class DistanceStrategy : SelectBaseStrategy
    {
        private bool _isReverse = false;

        public override List<Pair> Match(List<Individual> individuals)
        {
            throw new System.NotImplementedException();
        }

        public DistanceStrategy Reverse()
        {
            _isReverse = !_isReverse;
            return this;
        }
    }
}