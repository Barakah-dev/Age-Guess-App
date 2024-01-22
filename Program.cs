using System.ComponentModel.DataAnnotations;

namespace AgeGuessApp;

class Program
{
    static void Main(string[] args)
    {
        Display();

        InputName();

        while (true)
        {
            Console.WriteLine("Enter a number from 20 to 25 to guess Barbie's age");
            //int correctAge = 22;
            Random random = new Random();
            int correctAge = random.Next(20, 26);
            int guess = 0;

        
            while (guess != correctAge)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Result(ConsoleColor.Red, "Incorrect! age should be in number");
                    continue;
                }
               
                guess = Int32.Parse(input);

                if (guess != correctAge)
                {   
                    Result(ConsoleColor.Red, "You are wrong, please input correct age");
                    
                }
                
            }
        
            Result(ConsoleColor.Green, $"Your guess is right, Barbie is {guess} years old");

            Console.WriteLine("Play again? (Y or N)");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
               continue;
            }
            else if (answer == "N")
            {
                return;
            }
            else
            {
                return;
            }
        
        }
    }

        

    static void Display()
    {
        string appName = "AgeGuessApp";
        string appVersion = "1.0.0";
        string appAuthor = "Barakah";

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        Console.ResetColor();
    }

    static void InputName()
    {
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("It is nice to have you here {0}", name);
    }

    static void Result(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}