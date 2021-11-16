using System;

Main();
void Main()
{
    Console.WriteLine("Guess the secret number!");
    Console.WriteLine("------------------------------");
    Console.WriteLine();

    int answer = int.Parse(Console.ReadLine());
    // allows a user to input a number and displays it back on the screen
    int secretNumber = 42;
    // define the secret number
    for (int i = 0; i < 4; i++)
    {
        if (answer == secretNumber)
        {
            Console.WriteLine("Correct guess!");
            //displays if the user selects the correct number
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Guess again!");
            //displays if the user selects the incorrect number
            answer = int.Parse(Console.ReadLine());
        }
    }
}
