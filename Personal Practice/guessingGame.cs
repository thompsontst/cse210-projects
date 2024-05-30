using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
    int min = 1;
    int max = 100;
    int number;
    int guess;
    int guesses;
    bool playagain = true;
    string response;

    while (playagain)
    {
        guess = 0;
        guesses = 0;
        response = "";
        number = random.Next(min, max+1);
        while (guess != number)
        {
            Console.WriteLine($"Guess a number between {min} - {max}");
            Console.WriteLine($"Please Enter a number below!");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine($"Guess: {guess} is too high");

            } 
            else if (guess < number)
            {
                Console.WriteLine($"Guess: {guess} is too low");
            }
             guesses++;
        }
    
        Console.WriteLine($"The Number: {number} is Correct");
        Console.WriteLine("You win");
        Console.WriteLine($"You guess {guesses} times");
        
        Console.WriteLine($"Do you want to play again? Answer (Y/N)");
        response = Console.ReadLine();
        response = response.ToUpper();
        if (response == "Y")
        {
            playagain = true;
        }
        else {
            playagain = false;
        }
        }
        Console.WriteLine($"Thanks for playing");
    }

    }