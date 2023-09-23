using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// string of integers, return sorted list of deduplicated 
class Program {
  public static void Main (string[] args) {
    Console.WriteLine (JsonConvert.SerializeObject(SortAndDedupe("8,1,3,4,4,55,7")));
  }

  // Input - "8,1,3,4,4,55,7"

  // Expected Output - 1,3,4,7,8,55

  public static List<int> SortAndDedupe(string unsortedInts)
  {
    return unsortedInts
      .Split(",")
      .Select(s => Convert.ToInt32(s))
      .OrderBy(i  => i)
      .Distinct()
      .ToList();
  }
}