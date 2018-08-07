using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem2
    {
        public static void Execute()
        {
            int solution2 = SumOfEvenFibArray();
            Console.WriteLine("2) Sum of all even fib numbers less than 4000000: " + solution2);
        }
        public static int SumOfEvenFibArray()
        {
            // Knowing how addition works, we will only get an even number when we add two odds
            // By seeding the array this way, the even numbers will be 3rd, 6th, 9th, 12th, etc.
            List<int> fibArray = new List<int> { 0, 1, 1 };
            int sum = 0;
            for (int i = 3; true; i++)
            {
                fibArray.Add(fibArray[i - 2] + fibArray[i - 1]);
                if (fibArray[i] > 4000000)
                    break;
                if (i % 3 == 0)
                    sum += fibArray[i];
            }

            return sum;
        }
    }
}
