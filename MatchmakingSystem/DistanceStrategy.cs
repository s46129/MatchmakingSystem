using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    public class DistanceStrategy : ReverableBaseStrategy
    {
        protected override void ShowMatchTip()
        {
            Console.WriteLine($"Pair By{(IsReverse ? " Reverse " : " ")}Distance");
        }

        protected override Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            return waitForPair
                .OrderByDescending(individual => individual.Coord.Distance(pairIndividual.Coord))
                .First();
        }

        protected override Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            return waitForPair.OrderBy(individual => individual.Coord.Distance(pairIndividual.Coord))
                .First();
        }
    }
}