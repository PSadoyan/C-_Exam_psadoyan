using System;
using System.Collections.Generic;
using System.Linq;

/*
Problem #5 takes in a List of integers, and prints several modifications. It prints the even numbers, it prints the numbers in descending order, and it returns the sum of all numbers > 50. It does this using Linq Queries and a Linq method.

Useful Links:
https://learn.microsoft.com/en-us/dotnet/csharp/linq/
*/

class Linqing
{
  public int SumOver50(List<int> nums)
  {
    //The Linq Query directly below removes odd numbers from "nums." It also accounts for 0, which is not a real even number.
    IEnumerable<int> evens =
      from num in nums
      where num % 2 == 0
      where num != 0
      select num;

    Console.WriteLine("The Evens: ");
    
    foreach (var i in evens)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n\n");
    
    //The Linq Query directly below sorts nums into descending order.
    IEnumerable<int> descend =
      from num in nums
      orderby num descending
      select num;

    Console.WriteLine("Descending Nums: ");

    foreach (var i in descend)
    {
        Console.Write(i + " ");
    }
    Console.Write("\n\n");
    Console.WriteLine("Sum of Nums > 50: ");

    //the Linq Method below sums all the numbers in "nums" where num > 50.
    int sumResult = nums.Where(num => num > 50).Sum();
    return sumResult;
  }
}