using System.Security.Authentication;

namespace MatchmakingSystem
{
    public class Individual
    {
        public int Id;

        public string Name;

        public string Gender;

        public int Age;

        public string Intro;

        public Habit Habits;

        public Coord Coord;


        public Individual(string name,string gender,int age,string habits, Coord coord, string intro=null)
        {
            if (age<18)
            {
                throw new AuthenticationException("Age < 18");
            }
            Name = name;
            Gender = gender;
            Age = age;
            Coord = coord;
            Habits = new Habit(habits);
            Intro = intro;
        }
    }
}