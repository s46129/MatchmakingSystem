using System;
using System.Collections.Generic;
using MatchmakingSystem.Strategy;

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
                    Console.WriteLine(individual.ToString());
                }

                Console.WriteLine("\n");
                if (pair.PairedIndividuals.Length == 2)
                {
                    Console.WriteLine(
                        $"Distance: {pair.PairedIndividuals[0].Coord.Distance(pair.PairedIndividuals[1].Coord):F}");
                }

                Console.WriteLine("--------------------");
            }
        }

        private void SetIndividualsId(List<Individual> individuals)
        {
            for (int i = 0; i < individuals.Count; i++)
            {
                int id = i;
                individuals[i].Id = id;
            }
        }
    }
}