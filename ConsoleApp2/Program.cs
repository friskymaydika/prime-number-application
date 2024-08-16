using System; // Imports the System namespace, which contains fundamental classes for basic operations.
using System.Collections.Generic; // Imports the System.Collections.Generic namespace, which contains classes for defining generic collections.

namespace PrimeNumberGenerator // Defines a namespace called PrimeNumberGenerator to organize the code.
{
    class Program // Defines a class called Program, which contains the main logic of the application.
    {
        static void Main(string[] args) // The Main method is the entry point of the application.
        {
            // Prints the title centered in the console.
            Console.WriteLine("=== Applications: Prime Number Generator ===".PadLeft(40));
            Console.WriteLine("\n--------------------------------------------\n"); // Prints a dashed line for separation.
            Console.WriteLine("Name: mochammad frisky maydika soleh"); // Prints the name.
            Console.WriteLine("NO: 18"); // Prints the number.
            Console.WriteLine("Class: X PPLG\n"); // Prints the class.

            int limit = 1000; // Sets the limit for prime number generation to 1000.
            List<int> primes = GeneratePrimes(limit); // Calls the GeneratePrimes method to get a list of prime numbers up to the limit.

            // Prints the prime numbers from 1 to the specified limit.
            Console.WriteLine($"Prime numbers from 1 to {limit}:\n");
            foreach (int prime in primes) // Iterates through each prime number in the list.
            {
                Console.WriteLine(prime); // Prints each prime number on a new line.
            }
        }

        // Defines a method to generate a list of prime numbers up to a specified limit.
        static List<int> GeneratePrimes(int limit)
        {
            List<int> primes = new List<int>(); // Initializes a new list to store prime numbers.

            // Iterates through numbers from 2 to the specified limit.
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i)) // Checks if the current number is prime.
                {
                    primes.Add(i); // Adds the prime number to the list.
                }
            }

            return primes; // Returns the list of prime numbers.
        }

        // Defines a method to check if a number is prime.
        static bool IsPrime(int num)
        {
            if (num <= 1) return false; // Returns false if the number is less than or equal to 1.
            if (num == 2) return true; // Returns true if the number is 2.

            // Iterates from 2 to the square root of the number.
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false; // Returns false if the number is divisible by any number in the range.
            }

            return true; // Returns true if the number is not divisible by any number in the range.
        }
    }
}
