using System;

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

        while (playerPosition < 100)
        {
            Console.WriteLine($"Player is currently at position {playerPosition}. Press Enter to simulate a player's turn.");
            Console.ReadLine();

            string option = GetOption();

            switch (option)
            {
                case "Ladder":
                    Console.WriteLine("Player found a ladder! Move forward.");
                    playerPosition += DiceValue();
                    Console.WriteLine($"Player moved from {playerPosition - DiceValue()} to {playerPosition}.");
                    break;
                case "Snake":
                    Console.WriteLine("Uh-oh! Player encountered a snake. Move backward.");
                    int previousPosition = playerPosition;
                    playerPosition -= DiceValue();
                    Console.WriteLine($"Player moved from {previousPosition} to {playerPosition}.");
                    break;
                default:
                    Console.WriteLine("No play. Stay in the same position.");
                    break;
            }

            // Ensure the player's position is within bounds
            if (playerPosition < 0)
                playerPosition = 0;
            else if (playerPosition >= 100)
                Console.WriteLine("Player reached the winning position (100)!");
            else if(playerPosition> 100)
            {
                Console.WriteLine($"Player reached the  position {playerPosition-DiceValue()}");
            }
        }
    }
}
