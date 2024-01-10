using System;
using System.ComponentModel.DataAnnotations;

namespace D_Practice
{
    internal class Homework0803
    {
        private int min = 0;
        private int max = 100;
        private int answer = 0;
        public int Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        private int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Homework0803()
        {
            this.Count = 5;
            var rand = new Random();
            answer = rand.Next(min, max);
        }

        public Homework0803(int count, int answer)
        {
            this.Count = count;
            this.answer = answer;
        }

        public bool TryFindNumber(int answer)
        {
            int number = 50;
            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine("TryNumber " + number);
                if (number == answer)
                    return true;
                else if (number > answer)
                {
                    max = number;
                }
                else
                {
                    min = number;
                }
                number = (min + max) / 2;
            }
            return false;
        }

        public void Game()
        {

            while (true)
            {
                Console.WriteLine($"Homework0803. Set game. Who choose number Person or PC?");
                string gameMode = Console.ReadLine();
                if (gameMode == "Person")
                {
                    try
                    {
                        Console.WriteLine($"Choose number.");
                        int answer = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Choose counter.");
                        int count = int.Parse(Console.ReadLine());
                        var homework0803 = new Homework0803(count, answer);
                        if (homework0803.TryFindNumber(answer))
                            Console.WriteLine("PC win");
                        else
                            Console.WriteLine("PC loose");
                    }
                    catch
                    {
                        Console.WriteLine("Use only numbers.");
                    }
                }
                else if (gameMode == "PC")
                {
                    var homework0803 = new Homework0803();
                    Console.WriteLine($"You have {homework0803.Count} tries. Write number:");
                    for (int i = 0; i < homework0803.Count; i++)
                    {
                        int number = int.Parse(Console.ReadLine());

                        if (number == homework0803.Answer)
                        {
                            Console.WriteLine("You win!");
                            break;
                        }
                        else if (number > homework0803.Answer)
                            Console.WriteLine("Your number bigger than PC number.");
                        else
                            Console.WriteLine("Your number smaller than PC number.");

                        if (i == homework0803.Count)
                        {
                            Console.WriteLine("You loose!");
                            break;
                        }
                        Console.WriteLine("Write number:");
                    }
                }
                else
                    Console.WriteLine("Write \"Person\" or \"PC\"");
            }
        }
    }
}