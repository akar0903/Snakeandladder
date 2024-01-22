using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    static string GetOption()
    {
        string[] options = { "No Play", "Ladder", "Snake" };
        return options[random.Next(options.Length)];
    }

    static int DiceValue()
    {
        return random.Next(1, 7);
    }

    static void Main()
    {
        int playerPosition = 0;
        int count = 0;

        while (playerPosition < 100)
        {
            Console.WriteLine("Die Count " + count++);
            Console.WriteLine($"Player is currently at position {playerPosition}. Press Enter to simulate a player's turn.");
            Console.ReadLine();

            string option = GetOption();

            switch (option)
            {
                case "Ladder":
                    Console.WriteLine("Player found a ladder! Move forward.");
                    playerPosition += DiceValue();
                    int a = random.Next(playerPosition, 101);
                    Console.WriteLine($"Player moved from {playerPosition} to {a}");
                    playerPosition = a;
                    break;
                case "Snake":
                    Console.WriteLine("Uh-oh! Player encountered a snake. Move backward.");
                    playerPosition += DiceValue();
                    int b = random.Next(1, playerPosition);
                    Console.WriteLine($"Player moved from {playerPosition} to {b}");
                    playerPosition = b;
                    break;
                default:
                    int previous = playerPosition;
                    playerPosition += DiceValue();

                    Console.WriteLine($"Player moved from {previous} to {playerPosition}.");

                    break;
            }
            if (playerPosition < 0)
                playerPosition = 0;
            else if (playerPosition >= 100)
            {
                Console.WriteLine("Total die count " + count);
                Console.WriteLine("Player reached the winning position (100)!");
            }
            else if (playerPosition > 100)
            {
                Console.WriteLine($"Player reached the position {playerPosition - DiceValue()}");
            }
        }
    }
}