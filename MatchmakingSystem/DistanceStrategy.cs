using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    public class DistanceStrategy : SelectBaseStrategy
    {
        private bool _isReverse = false;

        public override List<Pair> Match(List<Individual> individuals)
        {
            Console.WriteLine($"Pair By{(_isReverse ? " Reverse " : " ")}Distance");

            List<Pair> pairs = new List<Pair>();
            List<Individual> waitForPair = new List<Individual>(individuals);

            while (waitForPair.Count > 0)
            {
                Individual pairIndividual = waitForPair[0];
                waitForPair.Remove(pairIndividual);

                Individual bestPair;

                if (_isReverse)
                {
                    bestPair = waitForPair
                        .OrderByDescending(individual => individual.Coord.Distance(pairIndividual.Coord))
                        .First();
                }
                else
                {
                    bestPair = waitForPair.OrderBy(individual => individual.Coord.Distance(pairIndividual.Coord))
                        .First();
                }

                pairs.Add(new Pair(pairIndividual, bestPair));
                waitForPair.Remove(bestPair);
            }

            return pairs;
        }

        public DistanceStrategy Reverse()
        {
            _isReverse = !_isReverse;
            return this;
        }
    }
}