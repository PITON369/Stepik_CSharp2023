using System;
using System.Collections.Generic;

namespace E_LINQ
{
    public class Homework0911
    {
        // Using a file with the TOP100 chess players, find all players from Russia and sort them by year of birth in ascending order.
        public void HW_FindRusChessPlayers()
        {
            string[] strings = File.ReadAllLines(@"Top100ChessPlayers.csv");
            var players = File.ReadAllLines(@"Top100ChessPlayers.csv")
                .Skip(1)
                .Select(Player.Parse)
                .Where(player=>player.Country=="RUS")
                .OrderBy(player=>player.BirthDate)
                .ToList();

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
            Console.ReadLine();
        }

        public class Player
        {
            //"1;Carlsen, Magnus;g;NOR;2842;0;1990"
            public string ID { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }
            public string Rating { get; set; }
            public string BirthDate { get; set; }

            public override string ToString()
            {
                return $"{Name} {Country} {BirthDate}";
            }

        public static Player Parse(string parts)
        {
            string[] line = parts.Split(';');
            return new Player()
            {
                ID = line[0],
                Name = line[1],
                Country = line[3],
                Rating = line[4],
                BirthDate = line[6]
            };
        }
    }
    }
}