/*
 * Name:        Daniel McKinney
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 06, Three Short Problems
 * Date:        October 21, 2026
 * Description: A menu that keeps running until the user quits, offering three
 *              independent exercises or all three at once. Each exercise
 *              practices decisions and one of the four loops.
 */

//Variables and Objects

double numericalGrade;

char ex2Input;

int ex2Int;

int winTotal;

Random rng = new Random(4000);

//The Menu

System.Console.WriteLine("WELCOME TO LAB 06\n");

System.Console.WriteLine(" ====== MENU ======");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. Run all three");
System.Console.WriteLine("5. Quit\n");
System.Console.WriteLine("Please select a program (1-5).");

int userInput = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

if (userInput < 1 || userInput > 5)
{
    System.Console.WriteLine("INVALID INPUT: Please enter a number 1-5.");
}

if (userInput == 1 || userInput == 4)
{
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    System.Console.WriteLine("Please enter a numerical grade.");
    numericalGrade = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine();

    /* The Grade Checker throws an error message and asks for another input until it gets a valid numerical grade. This is
     * condition-controlled, and a while() is used, NOT a do...while(). The error loop needs to check the first user input BEFORE
     * triggering so it can skip itself altogether if the first user input is a valid grade.
     */
    while(numericalGrade < 0 || numericalGrade > 100)
    {
        System.Console.WriteLine("Numerical grade must be between 0 and 100.");
        System.Console.WriteLine("Please enter a numerical grade.");
        numericalGrade = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine();
    }

    if (numericalGrade >= 90)
    {
        System.Console.WriteLine($"{numericalGrade} earns an A.");
    }
    else if (numericalGrade >= 80)
    {
    System.Console.WriteLine($"{numericalGrade} earns a B.");
    }
    else if (numericalGrade >= 70)
    {
        System.Console.WriteLine($"{numericalGrade} earns a C.");
    }
    else if (numericalGrade >= 60)
    {
        System.Console.WriteLine($"{numericalGrade} earns a D.");
    }
    else
    {
        System.Console.WriteLine($"{numericalGrade} earns an F.");
    }
    System.Console.WriteLine();

}
if (userInput == 2 || userInput == 4)
{
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    ex2Input = 'y';
    ex2Int = 0;
    winTotal = 0;

    /* Exercise 2 repeats until the user wants to return to the menu; this is another condition-controlled loop, but it will use a
    * a do...while() rather than a while(). The do is (1) roll the dice and (2) ask the user to roll again or exit. The user
    * selects the Dice Roller to see at least one pair of numbers; the check needs to come AFTER the first iteration.
    */
    do
    {
        ex2Int++;
        int die1 = rng.Next(1, 7);
        int die2 = rng.Next(1, 7);
        int diceTotal = die1 + die2;

        System.Console.Write($"Roll {ex2Int}: {die1} and {die2}, total {diceTotal}. ");

        if (diceTotal == 2)
        {
            System.Console.WriteLine("Snake eyes.");
        }
        else if (die1 == die2)
        {
            System.Console.WriteLine("Doubles!");
        }
        else if ((diceTotal == 7) || (diceTotal == 11))
        {
            System.Console.WriteLine("A winner.");
            winTotal++;
        }
        else
        {
            System.Console.WriteLine();
        }

        System.Console.Write("Roll again? (y/n): ");
        ex2Input = char.ToLower(Console.ReadLine()[0]);

    }while(ex2Input != 'n');

    if (ex2Int == 1)
    {
        System.Console.Write($"\nYou rolled {ex2Int} time ");
    }
    else
    {
        System.Console.Write($"\nYou rolled {ex2Int} times ");
    }

    if (winTotal == 1)
    {
        System.Console.WriteLine($"and won {winTotal} time.");
    }
    else
    {
        System.Console.WriteLine($"and won {winTotal} times.");
    }
    System.Console.WriteLine();

}
if (userInput == 3 || userInput == 4)
{
    System.Console.WriteLine("=== Exercise 3: The Score Report ===\n");
}

System.Console.WriteLine("Goodbye.");




