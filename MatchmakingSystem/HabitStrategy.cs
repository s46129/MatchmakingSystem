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

        protected override Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            waitForPair = waitForPair.OrderBy(individual =>
                pairIndividual.Habits.HabitList.Length).ToList();
            
            return waitForPair.OrderBy(individual =>
                pairIndividual.Habits.HabitList.Intersect(individual.Habits.HabitList).Count()).First();
        }

        protected override Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual)
        {
            waitForPair = waitForPair.OrderBy(individual =>
                pairIndividual.Habits.HabitList.Length).ToList();

            return waitForPair.OrderByDescending(individual =>
                pairIndividual.Habits.HabitList.Intersect(individual.Habits.HabitList).Count()).First();
        }
    }
}