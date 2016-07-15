using System;
using System.Timers;
using _TimedPrime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPrime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsResultPrime()
        {
            //TODO: Use Timer instead of max value once implimented.
            //Timer t = new Timer(60 * 1000);
            int prime = PrimeCalc.MyPrimeFinder(1000000);
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
        public void ApplicationTimeOutput()
        {
            //Does the application output the time?
            //Assert.IsTrue(false);
            throw new NotImplementedException("");
        }
        [TestMethod]
        public void PrimeCalculationStopsAt60Seconds()
        {
            //Does the application always stop calculating when time is up?
            Assert.IsTrue(false);
            throw new NotImplementedException("");
        }
    }
}
