using System;

class Product
    {
    static void Main(string[] args) {
        DateTime today = DateTime.Now;

        Console.WriteLine("Enter your first name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter your last name");
        string LastName = Console.ReadLine();

        Console.WriteLine("Hello " + FirstName + " " + LastName + ", let's play a game!");
        while (true)
        {

            Random random = new Random();
            int correct = random.Next(1, 50);
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 50.");
            while (guess != correct)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Write an actual number");
                    Console.ResetColor();
                    continue;
                }
                guess = Int32.Parse(input);
                if (guess != correct)
                {

                    if (Math.Abs(guess - correct) <= 2 && Math.Abs(guess - correct) > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You are close, keep going");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();
                    }
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are correct");
            Console.ResetColor();
            Console.WriteLine("Play again? [Y or N]");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N")
            {
                return;
            }
            else {
                return;
            }
        }

    }
}

