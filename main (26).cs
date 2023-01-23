using System;

class Program {
  public static void Main (string[] args) {
  //----------------arrays-----------------
    
    
       int[] num = new int [8];
      int sum = 0;
     Console.Write("Enter Double value: ");
       userInput = Console.ReadLine();
    Console.WriteLine("Enter the array elements");
      for(int i = 0; i < 8; i++)
      {
      num[i] = Convert.ToDouble(Console.ReadLine());
        sum += num[i];
      }
    Console.WriteLine("Array elements are");
      for(int i = 0; i < 8; i++)
      {
        Console.WriteLine(num[i]);
      }
    Console.WriteLine("Sum is {0}", sum);
    }
  }