using System;
using System.Collections.Generic;

/*
Problem #4 takes in a string array ("strings") and a substring ("query") and returns the number of times query occurs as a substring in the array strings. It does this by creating a List "results," and then iterating over "strings" and using the .Contains() method to check if "query" is a substring of any string in the array. All strings that contain "query" are added to the List "results." Finally, the "results" is turned into an array and returned.

In the case where "results" is empty, the function returns an array with a single value "Empty."

Used Links:
https://www.w3schools.com/cs/cs_arrays.php
*/

class StringSearch
{
  public string[] strSearch(string query, string[] strings)
  {
    List<string> results = new List<string>();
    query = query.ToLower();
    for (int i = 0; i < strings.Length; i++)
    {
      strings[i] = strings[i].ToLower();
      if (strings[i].Contains(query))
      {
        results.Add(strings[i]);
      }
    }
    if (results.Count == 0)
    {
      string[] emptyResult = {"Empty"};
      return emptyResult;
    }
    return results.ToArray();
  }
}