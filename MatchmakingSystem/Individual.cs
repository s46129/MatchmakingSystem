using System;
using System.Collections.Generic;
using System.Security.Authentication;

namespace MatchmakingSystem
{
    public class Individual
    {
        public int Id;

        private string Name;

        private string Gender;

        private int Age;

        private string Intro;

        public readonly List<Habit> Habits = new List<Habit>();

        // public readonly Habits Habits;
        public readonly Coord Coord;


        public Individual(string name, string gender, int age, string habitsString, Coord coord, string intro = null)
        {
            Name = name;
            Gender = gender;
            SetAge(age);
            Coord = coord;
            SetHabits(habitsString);
            Intro = intro;
        }

        void SetAge(int value)
        {
            if (value < 18)
            {
                throw new AuthenticationException("Age < 18");
            }

            Age = value;
        }

        void SetHabits(string habitsString)
        {
            string[] splitHabits = habitsString.Split(',');
            foreach (string habitString in splitHabits)
            {
                Habits.Add(new Habit(habitString));
            }
        }

        public override string ToString()
        {
            string info = string.Concat(
                $"\n------ {Id}. {Name} ------",
                $"\nAge: {Age}",
                $"\nGender : {Gender}",
                $"\nCoord: X:{Coord.X} Y:{Coord.Y}",
                "\nHabit:\n");
            foreach (var habit in Habits)
            {
                info += $"{habit.Name} ";
            }

            return info;
        }
    }
}