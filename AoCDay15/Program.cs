using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AoCDay15
{
    class Program
    {
        public static void Main()
        {
            var Input = File.ReadAllText(@"C:\Users\Mark\source\repos\AoCDay15\AoCDay15\input.txt");
            var Splitput = Input.Split(',');

            Console.WriteLine("The Output for Part 1 is: " + Part1(Splitput));
            Console.WriteLine("The Output for Part 2 is: " + Part2(Splitput));
        }

        static int Part1(string[] Input)
        {
            int FinalTotal = 0;
            foreach(string s in Input)
            {
                FinalTotal += ConvertASCII(s);
            }
            return FinalTotal;
        }

        static string Part2(string[] Input)
        {

        }

        static int ConvertASCII(string Input)
        {
            int Total = 0;
            foreach (var item in Input)
            {
                Total = ((Total + Convert.ToInt32(item)) * 17) % 256;
            }
            return Total;
        }
    }
}
