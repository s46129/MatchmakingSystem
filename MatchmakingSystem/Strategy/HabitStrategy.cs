using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem.Strategy
{
    public class HabitStrategy : ReverableBaseStrategy
    {
        protected override void ShowMatchTip()
        {
            Console.WriteLine($"Pair By {(IsReverse ? "different" : "same")} Habit");
        }

        protected override Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            waitForPair = waitForPair.OrderBy(individual =>
                pairIndividual.Habits.Count).ToList();

            return waitForPair.OrderBy(individual =>
                pairIndividual.Habits.Intersect(individual.Habits).Count()).First();
        }

        protected override Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            waitForPair = waitForPair.OrderBy(individual =>
                pairIndividual.Habits.Count).ToList();

            return waitForPair.OrderByDescending(individual =>
                pairIndividual.Habits.Intersect(individual.Habits).Count()).First();
        }
    }
}