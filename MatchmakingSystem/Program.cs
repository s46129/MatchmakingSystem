using System;
using System.Collections.Generic;

namespace MatchmakingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MatchSystem matchSystem = new MatchSystem(new FakeDataMaker().FakeData(30), new HabitBase());
        }

    }
}