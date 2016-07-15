﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;

namespace _TimedPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Allow users to specify how much time they want the method to run for.
            //TODO: Cap the Prime Number Finder by time instead of max value.
            //Timer t = new Timer(60 * 1000);
            //t.Start();
            PrimeCalc.Greeter();

            Console.WriteLine("The largest Prime found is: {0}", PrimeCalc.MyPrimeFinder(50000));
            Console.WriteLine("Thank you for using. Please press any key to close.");
            Console.ReadKey();

        }

    }

    public static class PrimeCalc
    {
        public static void Greeter()
        {
            Console.WriteLine("Welcome. This program will calculate the largest Prime Number it can in 60 seconds. ");

        }

        //This is my experiment to see how only testing existing primes will work
        public static int MyPrimeFinder(int maxvalue)
        {
            List<int> PrimesFound = new List<int> { 2, 3 };
            int currentNumber = 5;
            bool currentNumberIsPrime;
            //TODO: Change this to be time based instead of a max value to check.
            while (currentNumber < maxvalue)
            {
                currentNumberIsPrime = true;
                int boundary = (int)Math.Floor(Math.Sqrt(currentNumber));
                //Foreach will use more stackspace than a regular for loop, but my theory is that only checking primes will ultimately be faster.
                //Will test for speed and to see if it correctly finds primes.
                foreach (int i in PrimesFound.Where(x => x <= boundary))
                {
                    if (currentNumber % i == 0)
                    {
                        currentNumberIsPrime = false;
                        break;
                    } 
                }
                if (currentNumberIsPrime)
                {
                    PrimesFound.Add(currentNumber);
                    Console.WriteLine(currentNumber);
                }
                currentNumber += 2;
            }
            return PrimesFound.Max();

        }
    }
}