using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int[] arr = {100 , 26, 886, 2000};
    Array.Sort(arr);
    double x = Math.Sqrt(arr[1]);
    Console.WriteLine(x);
  }
}
