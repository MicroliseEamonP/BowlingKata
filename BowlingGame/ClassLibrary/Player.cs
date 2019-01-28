using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public int CurrentScore { get; set; }
        public Frame[] Frames { get; set; }
        public bool IsPrevFrameStrike { get; set; }
        public bool IsPrevFrameSpare { get; set; }

        public Player()
        {
        }

        public Player(string name)
        {
            Name = name;
        }

        public void UpdateScore()
        {
            foreach(var frame in Frames)
            {
                CurrentScore += frame.TotalScore;
            };
        }
    }
}
