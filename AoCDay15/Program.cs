using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCDay15
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Input = File.ReadAllText(@"C:\Users\Mark\source\repos\AoCDay15\AoCDay15\input.txt");
            var Splitput = Input.Split(',');
            int Total = 0;
            int FinalTotal = 0;

            foreach (var split in Splitput)
            {
                foreach (var item in split)
                {
                    Total = ((Total + Convert.ToInt32(item)) * 17) % 256;
                }
                FinalTotal += Total;
                Total = 0;
            }
            Console.WriteLine(FinalTotal);
        }
    }
}
