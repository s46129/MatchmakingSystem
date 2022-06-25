using System.Collections.Generic;

namespace MatchmakingSystem
{
    public abstract class ReverableBaseStrategy : IMatchmakingStrategy
    {
        protected bool IsReverse = false;

        public List<Pair> Match(List<Individual> individuals)
        {
            ShowMatchTip();

            List<Pair> pairs = new List<Pair>();
            List<Individual> waitForPair = new List<Individual>(individuals);

            while (waitForPair.Count > 0)
            {
                Individual pairIndividual = waitForPair[0];
                waitForPair.Remove(pairIndividual);

                Individual bestPair;
                if (IsReverse)
                    bestPair = FindBestPairIndividual(waitForPair, pairIndividual);
                else
                    bestPair = FindReversePairIndividual(waitForPair, pairIndividual);

                pairs.Add(new Pair(pairIndividual, bestPair));
                waitForPair.Remove(bestPair);
            }

            return pairs;
        }

        protected abstract void ShowMatchTip();

        protected abstract Individual FindBestPairIndividual(List<Individual> waitForPair, Individual pairIndividual);

        protected abstract Individual FindReversePairIndividual(List<Individual> waitForPair, Individual pairIndividual);

        public ReverableBaseStrategy Reverse()
        {
            IsReverse = !IsReverse;
            return this;
        }
    }
}