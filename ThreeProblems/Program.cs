/*
 * Name:        Daniel McKinney
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 06, Three Short Problems
 * Date:        October 21, 2026
 * Description: A menu that keeps running until the user quits, offering three
 *              independent exercises or all three at once. Each exercise
 *              practices decisions and one of the four loops.
 */

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
    System.Console.WriteLine("INVALID INPUT: Please enter a number 1-5.\n");
}

if (userInput == 1 || userInput == 4)
{
    System.Console.WriteLine("The Grade Checker\n");
}
if (userInput == 2 || userInput == 4)
{
    System.Console.WriteLine("The Dice Table\n");
}
if (userInput == 3 || userInput == 4)
{
    System.Console.WriteLine("The Score Report\n");
}

System.Console.WriteLine("Goodbye.");