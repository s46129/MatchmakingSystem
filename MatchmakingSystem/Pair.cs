namespace MatchmakingSystem
{
    public class Pair
    {
        public Individual[] PairedIndividuals { get; }

        public Pair(params Individual[] pairedIndividual)
        {
            PairedIndividuals = pairedIndividual;
        }
    }
}