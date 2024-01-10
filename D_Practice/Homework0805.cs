using System;

namespace D_Practice
{
    internal class Homework0805
    {
        private char[,] print = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        public void Game()
        {
            Console.WriteLine("Game start");
            while (true)
            {
                printGame();
                Console.WriteLine($"First player turn;");
                string tmpString = Console.ReadLine();
                int x = int.Parse(tmpString.Substring(0,1));
                int y = int.Parse(tmpString.Substring(1, 1));
                if (tmpString != null)
                    print[x, y] = 'X';
                printGame();
                if (Same())
                {
                    Console.WriteLine("First player win!");
                    break;
                }

                Console.WriteLine("Second player turn");
                tmpString = Console.ReadLine();
                x = int.Parse(tmpString.Substring(0, 1));
                y = int.Parse(tmpString.Substring(1, 1));
                if (tmpString != null)
                    print[x, y] = 'O';
                if (Same())
                {
                    Console.WriteLine("Second player win!");
                    break;
                }
            }
        }

        public void printGame()
        {
            for (int i = 0; i < 3; i++)
                Console.Write(print[0, i] + " | ");
            Console.WriteLine();
            Console.WriteLine("-----------");
            for (int i = 0; i < 3; i++)
                Console.Write(print[1, i] + " | ");
            Console.WriteLine();
            Console.WriteLine("-----------");
            for (int i = 0; i < 3; i++)
                Console.Write(print[2, i] + " | ");
            Console.WriteLine();
            Console.WriteLine();
        }

        private bool Same()
        {
            bool same = false;
            if (
                                        (print[0, 0] != ' ' && print[0, 0] == print[1, 1] && print[0, 0] == print[2, 2]) ||
                                        (print[0, 2] != ' ' && print[0, 2] == print[1, 1] && print[0, 2] == print[2, 0]) ||
                                        (print[0, 0] != ' ' && print[0, 0] == print[0, 1] && print[0, 0] == print[0, 2]) ||
                                        (print[1, 0] != ' ' && print[1, 0] == print[1, 1] && print[1, 0] == print[1, 2]) ||
                                        (print[2, 0] != ' ' && print[2, 0] == print[2, 1] && print[2, 0] == print[2, 2]) ||
                                        (print[0, 0] != ' ' && print[0, 0] == print[1, 0] && print[0, 0] == print[2, 2]) ||
                                        (print[0, 1] != ' ' && print[0, 1] == print[1, 1] && print[0, 1] == print[0, 2]) ||
                                        (print[0, 2] != ' ' && print[0, 2] == print[1, 2] && print[0, 2] == print[0, 2])
               )
                same = true;
            return same;
        }
    }
}