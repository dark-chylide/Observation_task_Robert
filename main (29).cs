using System;

class Program {
  public static void Main (string[] args) {
            int n = 5;
        for (int i = n; i > 0; i--)
        {
          for(int j = i; j > 0; j--)
          {  
            Console.Write("*");
          }
            Console.WriteLine();
        }
  }
}