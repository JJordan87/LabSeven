

Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("Where all your dreams come true!");
Console.WriteLine();

int diceSides = 0;
while (true)
{
    Console.WriteLine("How many sides should each die have?");


    bool isInt = int.TryParse(Console.ReadLine(), out diceSides);
    if (isInt && diceSides <= 120 && diceSides >= 2)
    {
        break;
    }
    else
    {
        Console.WriteLine("That is not a valid input.");
    }

}

bool rollAgain = true;
while (rollAgain)
{
    Console.WriteLine("Press enter to test your luck & roll the dice.");
    Console.ReadLine();

    int firstDie = RollDice(diceSides);
    int secondDie = RollDice(diceSides);
    string winner = RollSixSidedDie(firstDie, secondDie);
    string dNd = RollTwentySideDie(firstDie, secondDie);

    if(diceSides == 6)
    {
        Console.WriteLine($"You rolled a {firstDie} & {secondDie} ({firstDie + secondDie} total)");
        Console.WriteLine(winner);
        Console.WriteLine();
        while (rollAgain)
        {
            Console.WriteLine("Would you like to roll again? (y/n)");
            string userChoice = Console.ReadLine().ToLower().Trim();
            if (userChoice == "y")
            {
                rollAgain = true;
                break;
            }
            else if (userChoice == "n")
            {
                Console.WriteLine("Thanks for playing!!");
                rollAgain = false;
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input.");
            }
        }
    }
    else if (diceSides == 20)
    {
        Console.WriteLine($"You rolled a {firstDie} & {secondDie} ({firstDie + secondDie} total)");
        Console.WriteLine(dNd);
        Console.WriteLine();
        while (rollAgain)
        {
            Console.WriteLine("Would you like to roll again? (y/n)");
            string userChoice = Console.ReadLine().ToLower().Trim();
            if (userChoice == "y")
            {
                rollAgain = true;
                break;
            }
            else if (userChoice == "n")
            {
                Console.WriteLine("Thanks for playing!!");
                rollAgain = false;
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input.");
            }
        }
    }
    else
    {
        Console.WriteLine($"You rolled a {firstDie} & {secondDie} ({firstDie + secondDie} total)");
        Console.WriteLine();
        while (rollAgain)
        {
            Console.WriteLine("Would you like to roll again? (y/n)");
            string userChoice = Console.ReadLine().ToLower().Trim();
            if (userChoice == "y")
            {
                rollAgain= true;
                break;
            }
            else if (userChoice == "n")
            {
                Console.WriteLine("Thanks for playing!!");
                rollAgain = false;
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input.");
            }
        }
    }
}


static int RollDice (int diceSides)
{
    Random rndNum = new Random();
    int diceRoll = rndNum.Next(1, diceSides +1);
    return diceRoll;
}


static string RollSixSidedDie (int firstDie, int secondDie)
{
    if(firstDie == secondDie && firstDie == 1)
    {
        return "Snake Eyes";
    }
    if (firstDie == 1 && secondDie == 2 || firstDie == 2 && secondDie == 1)
    {
        return "Ace Deuce";
    }
    if (firstDie == 6 && secondDie == 6)
    {
        return "Box Cars";
    }
    if (firstDie + secondDie == 7 || firstDie + secondDie == 11)
    {
        return "Win";
    }
    if (firstDie + secondDie == 2 || firstDie + secondDie == 3 || firstDie + secondDie == 12)
    {
        return "Craps!";
    }
    else
    {
        return "";
    }
}

static string RollTwentySideDie (int firstDie, int secondDie)
{
    if(firstDie == 20 || secondDie == 20)
    {
        return "Thats a Critical Hit! How would you like to make this kill?";
    }
    if (firstDie == 1 && secondDie == 1)
    {
        return "You missed! Whomp, Whomp!";
    }
    else
    {
        return "";
    }
}








//Method to roll dice
