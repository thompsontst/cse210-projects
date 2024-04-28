using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // initiating the random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 200);
        
         string  answer;
        int guessNumber = -1;
        
        
        while (guessNumber != magicNumber)
        {
            
            Console.Write("What is the magic Number? ");
            guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber < magicNumber)
             {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
            
        }

       
    }
}