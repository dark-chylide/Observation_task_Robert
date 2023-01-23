using System;

class Program
{
    public static void Main(string[] args)
    {
        string user1, user2;
        Console.WriteLine("User 1: enter rock, paper, or scissors");
        user1 = Console.ReadLine();

        Console.WriteLine("User 2: enter rock, paper, or scissors");
        user2 = Console.ReadLine();

        if (user1 == "rock")
        {
            if (user2 == "paper")
            {
                Console.WriteLine("user2 has won");
            }
            if (user2 == "rock")
            {
                Console.WriteLine("Tie");
            }
            if (user2 == "scissors")
            {
                Console.WriteLine("user1 has won");
            }
        }
        else if (user1 == "paper")
        {
        if (user2 == "paper")
            {
                Console.WriteLine("Tie");
            }
            if (user2 == "rock")
            {
                Console.WriteLine("user1 has won");
            }
            if (user2 == "scissors")
            {
                Console.WriteLine("user2 has won");
            }
        }
        else
        {
        if (user2 == "paper")
            {
                Console.WriteLine("user1 has won");
            }
            if (user2 == "rock")
            {
                Console.WriteLine("user2 has won");
            }
            if (user2 == "scissors")
            {
                Console.WriteLine("Tie");
            }
        }
    }
}