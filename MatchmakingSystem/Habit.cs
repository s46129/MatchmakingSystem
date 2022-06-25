namespace MatchmakingSystem
{
    public class Habit
    {
        public Habit(string habits)
        {
            HabitList = habits.Split(',');
        }

        public readonly string[] HabitList;
    }
}