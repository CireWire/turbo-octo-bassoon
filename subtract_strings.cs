using System;

class MainClass
{
  public static void Main (string[] args)
  {
    string s = "Team Rocket";
    int x = s.Length; // 11
    int y = s.IndexOf("e"); //1
  /* 
  Output is going to be the difference of length of
  the string and the index of the first "e" in
  the string
  */
    Console.WriteLine(x - y);
  }
}
