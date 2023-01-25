using System;

class Program
{
    public static void Main(string[] args)
    {
        //--------------------1a------------------------
        int n;
        int sum = 0;

        for (n = 0; n <= 10; n++)
        {
            sum = sum + n;
        }
        Console.WriteLine("Sum is = " + sum);

        do
        {
            n++;
        }
        while (n <= 10);

        while (n <= 10)
        {
            n++;
        }
        //-------------------1b------------------------
      for(n = 0; n <= 10; n+=2)
        {
            sum = sum + n;
        }
        Console.WriteLine("Sum is = " + sum);

        do
        {
            n += 2;
        }
        while (n <= 10);

        while (n <= 10)
        {
            n += 2;
        }
        //------------------------1c---------------------
        for (n = 25; n <= 75; n++)
        {
            sum = sum + n;
        }
        Console.WriteLine("Sum is = " + sum);
        do
        {
            n++;
        }
        while (n <= 75);
    
      while(n <= 75)
      {
        n++;
      }
  }
}
