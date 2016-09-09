using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpnCalc;

namespace RpnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            do
            {
                Console.Write(">> ");
                input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input)) break;

                try
                {
                    Console.WriteLine(" = " + RpnCalculator.Calculate(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            } while (true);
        }
    }
}
