using System;
using System.Collections.Generic;

namespace MatchmakingSystem
{
    public class MatchSystem
    {
        private List<Individual> _individuals;
        private IMatchmakingStrategy _matchmakingStrategy;

        public MatchSystem(List<Individual> individuals, IMatchmakingStrategy matchmakingStrategy)
        {
            SetIndividualsId(individuals);
            _individuals = individuals;
            this._matchmakingStrategy = matchmakingStrategy;
        }

        public List<Pair> StartMatch()
        {
            return _matchmakingStrategy.Match(_individuals);
        }

        public void ShowResult(List<Pair> result)
        {
            Console.WriteLine("===== Show Result =====\n");
            for (var index = 0; index < result.Count; index++)
            {
                Console.WriteLine($"----- Pair {index} -----");
                Pair pair = result[index];
                foreach (var individual in pair.PairedIndividuals)
                {
                    Console.WriteLine(
                        $"{individual.Id}. {individual.Name} => Age:{individual.Age}  ,Gender:{individual.Gender} \nHabit:{individual.Habits} ");
                }

                Console.WriteLine("\n");
            }
        }

        private void SetIndividualsId(List<Individual> individuals)
        {
            for (int i = 1; i < individuals.Count + 1; i++)
            {
                int id = i;
                individuals[i].Id = id;
            }
        }
    }
}