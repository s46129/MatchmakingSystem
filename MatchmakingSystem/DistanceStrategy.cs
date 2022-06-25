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

        protected override Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            Individual bestPair = waitForPair.OrderBy(individual => individual.Coord.Distance(pairIndividual.Coord))
                .First();
            return bestPair;
        }

        protected override Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            Individual bestPair = waitForPair
                .OrderByDescending(individual => individual.Coord.Distance(pairIndividual.Coord))
                .First();
            return bestPair;
        }
    }
}