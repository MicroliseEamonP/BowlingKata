using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var turnMan = new TurnManager();
            Console.WriteLine("Enter player names, type 'done' to start the game!");
            

            var input = Console.ReadLine();

            var names = input.Split(",");

            var players = new List<Player>();

            foreach (var item in names)
            {
                players.Add(new Player(item));
            }


            var turnManager = new TurnManager(players);

            

            Console.ReadLine();
        }
    }
}
