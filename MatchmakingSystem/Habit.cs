namespace MatchmakingSystem
{
	public class Habit
	{
		public Habit(string habits)
		{
			Habits = habits.Split(',');
		}
		public string[] Habits;
	}
}
