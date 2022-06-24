using System.Collections.Generic;

namespace MatchmakingSystem
{
    public class HabitStrategy : SelectBaseStrategy
    {
  
        private bool _isReverse = false;
        public override List<Pair> Match(List<Individual> individuals)
        {
            throw new System.NotImplementedException();
        }

        public HabitStrategy Reverse()
        {
            _isReverse = !_isReverse;
            return this;
        }
    }
}