using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Homework0509
    {        
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        //Реализовал два метода и разделил их вызов с помощью reserve с вызовом по умолчанию более короткого и простого метода
        internal int RomanNumerals(string str, bool reserve = false)
        {
            int result = 0;
            if (reserve == false)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i + 1 < str.Length && IsSubtractive(str[i], str[i + 1]))
                    {
                        result -= map[str[i]];
                    }
                    else
                    {
                        result += map[str[i]];
                    }
                }
            }
            else
            {
                bool d = false;
                bool c = false;
                bool l = false;
                bool x = false;
                bool v = false;
                bool i = false;
                int buffer = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[j] == 'M') && (d == true))
                    {
                        Console.WriteLine("Wrong input! You need write MD, not DM!");
                        return 0;
                    }
                    else if ((str[j] == 'C') && (l == true))
                    {
                        Console.WriteLine("Wrong input! You need write CL, not LC!");
                        return 0;
                    }
                    else if ((str[j] == 'X') && (v == true))
                    {
                        Console.WriteLine("Wrong input! You need write XV, not VX!");
                        return 0;
                    }
                    else if ((str[j] == 'M') && (d == false) && (c == false) && (l == false) && (x == false) && (v == false) && (i == false))
                    {
                        result += 1000;
                        result += buffer;
                        buffer = 0;
                    }
                    else if (str[j] == 'M')
                    {
                        result += 1000 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'D') && (d == false) && (c == false) && (l == false) && (x == false) && (v == false) && (i == false))
                    {
                        d = true;
                        result += 500;
                        result += buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'D'))
                    {
                        result += 500 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'C') && (c == false) && (l == false) && (x == false) && (v == false) && (i == false))
                    {
                        c = true;
                        result += 100;
                        result += buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'C'))
                    {
                        result += 100 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'L') && (l == false) && (x == false) && (v == false) && (i == false))
                    {
                        l = true;
                        result += 50;
                        result += buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'L'))
                    {
                        result += 50 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'X') && (x == false) && (v == false) && (i == false))
                    {
                        x = true;
                        result += 10;
                        result += buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'X'))
                    {
                        result += 10 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'V') && (v == false) && (i == false))
                    {
                        v = true;
                        result += 5;
                        result += buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'V'))
                    {
                        result += 5 - buffer;
                        buffer = 0;
                    }
                    else if ((str[j] == 'I') && (i == false))
                    {
                        buffer += 1;
                        i = true;
                    }
                    else
                    {
                        result -= 1;
                        i = true;
                    }
                }
            }
            return result;
        }

            private static bool IsSubtractive(char v1, char v2)
        {
            return map[v1] < map[v2];
        }      
    }
}