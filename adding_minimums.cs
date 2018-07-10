using System;
using System.Linq;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int[] a = {4,6,5,2};
    int x = a[0] + a.Min();
    Console.Write(x);
  }
}
