using System;
namespace Domain
{
    public class Dice
    {
        private static Random _randomizer = new();

        public int Dots { get; set; }

        public Dice()
        {
            Dots = 6;
        }

        public void Roll()
        {
            Dots = _randomizer.Next(1,7);
        }

    }
}

