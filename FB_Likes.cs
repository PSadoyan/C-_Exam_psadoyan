using System;

/*
Problem 2 takes in an array of Strings and prints out a response depending on the number of strings in the array. Because of the different formats for the different number of strings there are if-statements for lengths 0-3. Anything larger will follow the same format. Below I've provided an example array with 5 strings, but it works with any number (not including anything ginormous that will cause run-time issues. I'm watching you professor.)

Useful Links:
None for this one.
*/

class FB_Likes
{
  public void likes(String[] names)
  {
      
      if (names.Length == 0)
      {
          Console.WriteLine("no one likes this");
          return;
      }

      if (names.Length == 1)
      {
          Console.WriteLine(names[0] + " likes this");
          return;
      }

      if (names.Length == 2)
      {
          Console.WriteLine(names[0] + " and " + names[1] + " like this");
          return;
      }

      if (names.Length == 3)
      {
          Console.WriteLine(names[0] + ", " + names[1] + ", and " + names[3] + " like this");
          return;
      }

     Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Length-2) + " others like this");

  }
}