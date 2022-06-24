namespace MatchmakingSystem
{
    public class Pair
    {
        public Individual[] PairedIndividuals { get; }

        public Pair(Individual[] pairedIndividuals)
        {
            PairedIndividuals = pairedIndividuals;
        }
    }
}