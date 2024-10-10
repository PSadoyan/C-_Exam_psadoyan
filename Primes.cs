using System;

/*
Problem 1 uses a method "prime_checker" to check if a number is prime. "prime_checker" takes in a number, and checks whether it can be divided by any number between 2 and the sqrt of that number. Then, the Problem_1 method just runs "problem_checker" on a for_loop up to the number given (+1, to check the number itself).

Useful Links:
None for this one.
*/

class Primes 
{
  public void primes (int num) {
          for (int i = 0; i < num+1; i++)
          {
            if (prime_checker(i))
              {
              Console.Write(i + ", ");
              }
          }

      static bool prime_checker(int num)
      {

          if (num == 0 || num == 1)
          {
              return false;
          }
          else
          {
              for (int i = 2; i <= Math.Sqrt(num); i++)
              {
                  if (num % i == 0)
                  {
                      return false;
                  }
              }
              return true;
          }

      }
  }
}