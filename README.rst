===========
Timed Prime Number Generator
===========
Generates the highest prime number it can in 60 seconds, starting from 5 and outputting all primes found to the console.
Trying an experiment to see run times of my created algorithm compared to known bests. The inner loop is running through a List
of primes found so far instead of the usual every odd number.
I'm curious to see if the overhead of the List structure and foreach loop have much of an impact; especially considering this is 
an algorithm meant to run for 60 seconds.
::

    foreach (int i in PrimesFound.Where(x => x <= boundary))
    {
        if (currentNumber % i == 0)
        {
            currentNumberIsPrime = false;
            break;
        } 
    }


Usage
=====
	Windows is currently the only platform tested. 
	Open Solution with Visual Studio 2015 or run the compiled binary.

License
=======

Distributed under the terms of the `MIT`_ license.

.. _MIT: https://github.com/pytest-dev/pytest-mock/blob/master/LICENSE
