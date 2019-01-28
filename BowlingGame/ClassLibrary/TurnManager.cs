using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class TurnManager
    {
        IEnumerable<Player> Players;
        public TurnManager(IEnumerable<Player> players)
        {
            Players = players;
        }

        public void Start()
        {
            Random random = new Random();

            Console.WriteLine("Game starting");
            for (var turn = 0; turn < 10; turn++)
            {
                foreach(var player in Players)
                {
                    Console.WriteLine($"{player.Name}'s turn");

                    var bowlOne = random.Next(0, 10);

                    Console.WriteLine($"{player.Name}'s bowl one: {bowlOne}.");

                    int bowlTwo = 0;
                    if (bowlOne < 10)
                    {
                        bowlTwo = random.Next(0, 10 - bowlOne);
                        Console.WriteLine($"{player.Name}'s bowl one: {bowlTwo}.");
                    }

                    player.Frames[turn] = new Frame
                    {
                       BowlOne = bowlOne,
                       BowlTwo = bowlTwo
                    };
                    
                }
            }
        }
    }
}
