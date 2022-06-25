using System;

namespace MatchmakingSystem
{
    public class Coord
    {
        public float X;
        public float Y;

        public Coord(float x, float y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Coord target)
        {
            return Math.Pow(Math.Pow(X - target.X, 2) + Math.Pow(Y - target.Y, 2), 0.5f);
        }

    }
}