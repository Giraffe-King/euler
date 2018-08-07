using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem3
    {
        public static void Execute()
        {
            int solution3 = FindPrimeFactors(600851475143);
            Console.WriteLine("3) Largest prime factor of 600851475143 is: " + solution3);
        }


        public static int FindPrimeFactors(long num)
        {
            int largestFactor = 1;
            long reducedNum = num;
            int idx = 1;
            List<int> primes = new List<int> { 2, 3 };
            while (reducedNum % 2 == 0)
            {
                reducedNum = reducedNum / 2;
                largestFactor = 2;
                while (reducedNum % 2 == 0)
                    reducedNum = reducedNum / 2;
            }

            while (reducedNum % 3 == 0)
            {
                reducedNum = reducedNum / 3;
                largestFactor = 3;
                while (reducedNum % 3 == 0)
                    reducedNum = reducedNum / 3;
            }

            // Reduce until it is fully reduced by all factors
            while (reducedNum != 1)
            {
                // Find next prime number
                for (int i = primes[idx] + 2; true; i += 2) // Skip evens, evens are never prime
                {
                    bool isPrime = true;
                    foreach (int prime in primes)
                    {
                        if (i % prime == 0)
                        {
                            isPrime = false;
                        }
                    }

                    if (isPrime)
                    {
                        primes.Add(i);
                        idx++;
                        break;
                    }
                }

                if (reducedNum % primes[idx] == 0)
                {
                    reducedNum = reducedNum / primes[idx];
                    largestFactor = primes[idx];
                    while (reducedNum % primes[idx] == 0)
                        reducedNum = reducedNum / primes[idx];
                }
            }

            return largestFactor;
        }
    }
}
