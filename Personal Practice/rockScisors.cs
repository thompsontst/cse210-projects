using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
 
    string computer;
    string player;
    int guesses;
    bool playagain = true;
    string response;

    while (playagain)
    {
        player = "";
        computer = "";
        response = "";
        guesses = 0;
        
        while (player != "ROCK" && player != "PAPER" && player != "SCISSORS" )
        {
            Console.WriteLine($"Please Enter ROCK, PAPER OR SCISORS");
            Console.WriteLine($"Please Enter Your choice below!");
            player = Console.ReadLine();
            player = player.ToUpper();
        }
        switch (random.Next(1, 4))
        {
            case 1: 
            computer = "ROCK";
            break;

            case 2: 
            computer = "PAPER";
            break;
            
            case 3: 
            computer = "SCISSORS";
            break;
            
        }
        Console.WriteLine($"PLAYER: {player}");
        Console.WriteLine($"COMPUTER: {computer}");

            switch (player)
        {
            case "ROCK": 
            if (computer == "ROCK")
            {
            Console.WriteLine($"It is a draw");
            }
            
           else if (computer == "SCISSORS")
            {
            Console.WriteLine($"Congratulations You Won!!!");
            }

            else 
            {
            Console.WriteLine($"SORRY YOU LOST");
            }
            break;

            case "PAPER": 
            if (computer == "PAPER")
            {
            Console.WriteLine($"It is a draw");
            }
            
           else if (computer == "ROCK")
            {
            Console.WriteLine($"Congratulations You Won!!!");
            }

            else 
            {
            Console.WriteLine($"SORRY YOU LOST");
            }
            break;

            case "SCISSORS": 
                        if (computer == "SCISSORS")
            {
            Console.WriteLine($"It is a draw");
            }
            
           else if (computer == "PAPER")
            {
            Console.WriteLine($"Congratulations You Won!!!");
            }

            else 
            {
            Console.WriteLine($"SORRY YOU LOST");
            }
            break;
        }
             guesses++;
        
    
       
        
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