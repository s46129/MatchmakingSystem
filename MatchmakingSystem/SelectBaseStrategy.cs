using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    public abstract class SelectBaseStrategy : MatchmakingStrategy
    {
        public abstract Pair Match(Individual individual);
        public abstract void SelectBy();

        public Individual OnSameCondition(List<Individual> sameConditionIndividuals)
        {
            var orderedWithId = sameConditionIndividuals.OrderBy(individual => individual.Id);
            return orderedWithId.First();
        }
    }
}