using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem1
    {
        public static void Execute()
        {
            int solution1 = SumOfDivisibleBy(1000, 3) + SumOfDivisibleBy(1000, 5) - SumOfDivisibleBy(1000, 15);
            Console.WriteLine("1) Sum of all numbers visible by 3 or 5 is: " + solution1);
        }
        public static int SumOfDivisibleBy(double max, double divisor)
        {
            // This is clearly a growing series, which means there must be an equation to find it
            // By finding and plotting points, and knowing that this is an accelerating growth
            // we can find that the equation must be Y = ax^2+bx+c;
            // long story short, I used the series of equations method to find this equation
            int x = (int)((max - 1) / divisor);
            double ab = divisor / 2;

            return (int)(ab * x * x + ab * x);
        }
    }
}
