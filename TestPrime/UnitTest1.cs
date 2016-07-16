using System;
using _TimedPrime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestPrime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsResultPrime()
        {
            //edge case of one more than a number made by two primes squared.
            int prime = PrimeCalc.MyPrimeFinder(1370);
            bool isPrime = false;
            //Is the final result Prime?
            int boundary = (int)Math.Floor(Math.Sqrt(prime));

            if (prime == 1) Assert.IsTrue(isPrime);
            if (prime == 2) Assert.IsTrue(isPrime);

            isPrime = true;
            for (int i = 2; i <= boundary; ++i)
            {
                if (prime % i == 0) isPrime = false;
            }

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void PrimeCalculationStopsAt60Seconds()
        {
            //Does the application always stop calculating when time is up?
            Stopwatch test = new Stopwatch();
            test.Start();
            PrimeCalc.FindPrimesInTime(60000);
            test.Stop();
            Assert.IsTrue(test.ElapsedMilliseconds < 60010);

        }
    }
}
