using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    public abstract class SelectBaseStrategy : IMatchmakingStrategy
    {
        public abstract List<Pair> Match(List<Individual> individuals);

        public Individual OnSameCondition(List<Individual> sameConditionIndividuals)
        {
            var orderedWithId = sameConditionIndividuals.OrderBy(individual => individual.Id);
            return orderedWithId.First();
        }
    }
}