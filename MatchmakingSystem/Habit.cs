using System.Security.Authentication;

namespace MatchmakingSystem
{
    public class Habit
    {
        public string Name { get; }

        public Habit(string habit)
        {
            if (habit.Length > 10 || string.IsNullOrEmpty(habit))
            {
                throw new AuthenticationException("Habit Name length must >0 and <10.");
            }

            Name = habit;
        }
    }
}