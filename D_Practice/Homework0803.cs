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

        public int TryNumber(int number, int answer)
        {
            if (number == answer)
                return 2;
            else if (number > answer)
                return 1;
            else
                return 0;
        }
    }
}