using System;
class Program
{
    static void Main()
    {
        int playerposition = 0;
        int diceroll = DiceRoll();
        Console.WriteLine(diceroll);
        Console.ReadLine();
    }
    static int DiceRoll()
    {
        Random random = new Random();
        return random.Next(1, 7);

    }
    
}
