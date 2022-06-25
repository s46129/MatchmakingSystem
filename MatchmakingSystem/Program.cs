using System;
using System.Collections.Generic;
using System.Text;

namespace MatchmakingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //取得用戶資料
            List<Individual> individualsData = FakeDataMaker.GetFakeData(30);

            //選擇要配對的模式
            // IMatchmakingStrategy matchmakingStrategy = new HabitStrategy();
            IMatchmakingStrategy matchmakingStrategy = new HabitStrategy().Reverse();
            // IMatchmakingStrategy matchmakingStrategy = new DistanceStrategy();
            // IMatchmakingStrategy matchmakingStrategy = new DistanceStrategy().Reverse();

            //執行配對
            MatchSystem matchSystem = new MatchSystem(individualsData, matchmakingStrategy);
            List<Pair> result = matchSystem.StartMatch();
            matchSystem.ShowResult(result);
        }
    }
}