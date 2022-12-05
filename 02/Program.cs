
public class RockPaperScissors
{
    private const int ROCK = 0;
    private const int PAPER = 1;
    private const int SCISSORS = 2;

    public static void Main()
    {
        int points = 0;
        Console.WriteLine(Directory.GetCurrentDirectory());
        foreach (string line in File.ReadLines(@"C:\Users\VeronikaA\Documents\personal\aoc22\02\input.txt"))
        {
            string[] signs = line.Split(' ');
            int me = SignCleaner(signs[1]);
            int oponent = SignCleaner(signs[0]);

            if (me == oponent)
            {
                points += 3;
            }
            else
            {
                points += IsWinner(oponent, me);
            }
            points += SignPoints(me);
        }
        Console.WriteLine($" Points: {points }");
    }

    public static int IsWinner(int oponent, int me)
    {
        if (me == ROCK && oponent == PAPER)
        {
            return 0;
        }
        else if (me == PAPER && oponent == SCISSORS)
        {
            return 0;
        }
        else if (me == SCISSORS && oponent == ROCK)
        {
            return 0;
        }
        return 6;
    }

    public static int SignPoints(int sign) 
    {
        switch (sign)
        {
            case ROCK:
                return 1;
            case PAPER:
                return 2;
            case SCISSORS:
                return 3;
            default:
                break;
        }
        return 0;
    }

    public static int SignCleaner(string sign)
    {
        switch(sign)
        {
            case "A": case "X":
                return ROCK;
            case "B": case "Y":
                return PAPER;
            case "C": case "Z":
                return SCISSORS;
            default:
                break;
        }
        return 3;
    }
}