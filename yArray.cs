using System;

class MainClass {
  public static void Main (string[] args) {
    int [] yArray = {8, 2, 6};

    int y = 0;

    foreach (int x in yArray)
    {
     y += x/2;
    }
  Console.WriteLine(y);
  }
}
