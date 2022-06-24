using System.Collections.Generic;

namespace MatchmakingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Individual> individualsData = new FakeDataMaker().FakeData(30);
            IMatchmakingStrategy matchmakingStrategy = new HabitStrategy().Reverse();

            MatchSystem matchSystem = new MatchSystem(individualsData, matchmakingStrategy);
            List<Pair> result = matchSystem.StartMatch();
            matchSystem.ShowResult(result);
        }
    }
}