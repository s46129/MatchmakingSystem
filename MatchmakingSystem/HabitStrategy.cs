using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    public class HabitStrategy : ReverableBaseStrategy
    {
        protected override void ShowMatchTip()
        {
            Console.WriteLine($"Pair By {(IsReverse ? "different" : "same")} Habit");
        }

        protected override Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            throw new NotImplementedException();
        }

        protected override Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            throw new NotImplementedException();
        }
    }
}