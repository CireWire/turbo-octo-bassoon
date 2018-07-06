using System;

class MainClass {
  public static void Main (string[] args) {
    int [] nums = {5, 2, 3 , 4, 7, 8, 88, 46, 49, 51, 56, 77};
    foreach (int n in nums)
    {
      if(n % 2 == 0)
      Console.WriteLine(n);
    }
  }
}
