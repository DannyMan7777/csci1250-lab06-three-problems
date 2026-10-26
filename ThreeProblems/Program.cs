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

    //Menu

const int GRADE_CHECKER = 1;

const int DICE_ROLLER = 2;

const int SCORE_REPORT = 3;

const int ALL_THREE = 4;

const int QUIT_MENU = 5;

int userInput;

    //Ex 1

double numericalGrade;

const int MAXIMUM_SCORE = 100;

const int MINIMUM_A = 90;

const int MINIMUM_B = 80;

const int MINIMUM_C = 70;

const int MINIMUM_D = 60;

const int MINIMUM_SCORE = 0;

    //Ex 2

const int SEED = 4000;

Random rng = new Random(SEED);

const int DIE_MINIMUM = 1;

const int DIE_MAXIMUM = 6;

char ex2Input;

int ex2Int;

int winTotal;

    //Ex 3

string[] ordinalEndings = ["st", "nd", "rd", "th"];

const int SCORE_QUANTITY = 5;

//The Menu

System.Console.WriteLine("WELCOME TO CSCI-1250 Lab 06\n");


//A do...while() loop is employed so the menu runs once, then repeats as long as the user does not select 5 (quit the menu).
do{
System.Console.WriteLine(" ====== MENU ======");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. Run all three");
System.Console.WriteLine("5. Quit\n");
System.Console.WriteLine("Please select a program (1-5).");

userInput = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

/* The menu throws an error message and asks for another input until the user selects a valid option. This is
 * condition-controlled, and a while() is used, NOT a do...while(). The error loop needs to check the first user input BEFORE
 * triggering so it can skip itself altogether if the first user input is a valid option.
 */
while (userInput < GRADE_CHECKER || userInput > QUIT_MENU)
{
    System.Console.WriteLine("INVALID INPUT: Please enter a number 1-5.");
    System.Console.WriteLine("Please select a program (1-5).");
    userInput = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
}

if (userInput == GRADE_CHECKER || userInput == ALL_THREE)
{
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    System.Console.WriteLine("Please enter a numerical grade.");
    numericalGrade = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine();

    /* The Grade Checker operates on the same premise as the menu (take the first input, THEN check: run the loop for invalid
     * grades or skip the loop if the first grade is valid). Therefore, it also uses a while() and almost the same code.
     */
    while(numericalGrade < MINIMUM_SCORE || numericalGrade > MAXIMUM_SCORE)
    {
        System.Console.WriteLine("INVALID INPUT: Numerical grade must be between 0 and 100.");
        System.Console.WriteLine("Please enter a numerical grade.");
        numericalGrade = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine();
    }

    if (numericalGrade >= MINIMUM_A)
    {
        System.Console.WriteLine($"{numericalGrade} earns an A.");
    }
    else if (numericalGrade >= MINIMUM_B)
    {
    System.Console.WriteLine($"{numericalGrade} earns a B.");
    }
    else if (numericalGrade >= MINIMUM_C)
    {
        System.Console.WriteLine($"{numericalGrade} earns a C.");
    }
    else if (numericalGrade >= MINIMUM_D)
    {
        System.Console.WriteLine($"{numericalGrade} earns a D.");
    }
    else
    {
        System.Console.WriteLine($"{numericalGrade} earns an F.");
    }
    System.Console.WriteLine();

}

if (userInput == DICE_ROLLER || userInput == ALL_THREE)
{
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    ex2Int = 0;
    winTotal = 0;

    /* Exercise 2 repeats until the user wants to return to the menu; this is another condition-controlled loop, but it will use a
    * a do...while() rather than a while(). The do is (1) roll the dice and (2) ask the user to roll again or exit. The user
    * selects the Dice Roller to see at least one pair of numbers; the check needs to come AFTER the first iteration.
    */
    do
    {
        ex2Int++;
        int die1 = rng.Next(DIE_MINIMUM, (DIE_MAXIMUM + 1));
        int die2 = rng.Next(DIE_MINIMUM, (DIE_MAXIMUM + 1));
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

        #nullable disable //This because I literally could not figure out any other way to get rid of the null warning.
        System.Console.Write("Roll again? (y/n): ");
        ex2Input = char.ToLower(Console.ReadLine()[0]);
        #nullable restore

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

if (userInput == SCORE_REPORT || userInput == ALL_THREE)
{
    System.Console.WriteLine("=== Exercise 3: The Score Report ===\n");

    int j;

    double[] scores = new double[SCORE_QUANTITY];

    for (int i = 0; i < scores.Length; i++)
    {
        if (i == 0)
        {
            j = 0;
        }
        else if (i == 1)
        {
            j = 1;
        }
        else if (i == 2)
        {
            j = 2;
        }
        else
        {
            j = 3;
        }

        System.Console.WriteLine($"Please enter your {i + 1}{ordinalEndings[j]} score.");
        scores[i] = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine();

        /* The algorithm that collects scores to assemble an array runs the same error check loop as the menu and the Grade
         * Checker, so it, too utilizes a while() loop with similar code (the difference is greater here because of the array).
         */
        while(scores[i] < MINIMUM_SCORE || scores[i] > MAXIMUM_SCORE)
        {
            System.Console.WriteLine("INVALID INPUT: Score must be between 0 and 100.");
            System.Console.WriteLine($"Please enter your {i + 1}{ordinalEndings[j]} score.");
            scores[i] = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine();
        }
    }

    System.Console.WriteLine("=== Your Scores ===");

    double scoreSum = 0;
    double scoreHighest = 0;
    int passingScoreQuantity = 0;
    int scoreCount = 1;
        
    foreach (double score in scores)
    {
        System.Console.WriteLine($"Score {scoreCount++}: {score}");
        scoreSum += score;
        if (score >= MINIMUM_D)
        {
            passingScoreQuantity++;
        }
        scoreHighest = Math.Max(score, scoreHighest);
    }

    double scoreMean = scoreSum / scores.Length;

    System.Console.WriteLine($"\nScores entered: {scores.Length}");
    System.Console.WriteLine($"Total: {scoreSum}");
    System.Console.WriteLine($"Average: {scoreMean:F1}");
    System.Console.WriteLine($"Highest: {scoreHighest}");
    System.Console.WriteLine($"Passing: {passingScoreQuantity} of {scores.Length}\n");
}

} while(userInput != QUIT_MENU);

System.Console.WriteLine("Goodbye.\n");
