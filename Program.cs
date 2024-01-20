using System;
class Program
{
    static void Main()
    {

        int diceroll = DiceRoll();
        //Console.WriteLine(diceroll);
        play();
        Console.ReadLine();
    }
    static int DiceRoll()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }
    static int position()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }
   

    static string GetOption()
    {
        Random random = new Random();
        string[] options = { "No Play", "Ladder", "Snake" };
        return options[random.Next(options.Length)];
    }

    static void play()
    {
        Console.WriteLine("Press Enter to simulate a player's turn.");
        Console.ReadLine();

        string option = GetOption();

        switch (option)
        {
            case "Ladder":
                Console.WriteLine($"found a ladder.Move from {position()} to {position() + DiceRoll()}");
                break;
            case "Snake":
                Console.WriteLine($"Player encountered a snake.Move from {position()} to {position() - DiceRoll()}.");
                break;
            default:
                Console.WriteLine("Stay in the same position.");
                break;
        }
    }
}

   




