using System;
using System.Collections.Generic;

namespace Exerciseracking
{
public class Program
{
    static void Main(string[] args)
    {
        double distance = 0;
        int LengthOfTime = 0;
        int dateTimeday = 0;
        int swimminglaps = 0;
        double cyclingSpeed = 0;
        int dateTimemonth = 0;
        int dateTimeyear = 0;
       
     
         
         bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter the exercise activity From the Menu");
                Console.WriteLine("1. Swimming Exercise");
                Console.WriteLine("2. Cycling Exercise");
                Console.WriteLine("3. Running Exercise");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the swimming Lap: ");
                        swimminglaps = Convert.ToInt32(Console.ReadLine());


                        Console.Write("Enter the Lenghth of Time in Minutes: ");
                        LengthOfTime = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the day: ");
                                dateTimeday = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the month: ");
                                dateTimemonth = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the year: ");
                                dateTimeyear = Convert.ToInt32(Console.ReadLine());
                               Swimming swim =  new Swimming(new DateTime(dateTimeyear, dateTimemonth,dateTimeday), LengthOfTime, swimminglaps);
                                swim.DisplayexerciseSummary();
                        break;
                    case "2":
                       Console.Write("Enter Cycling Speed In Min/km ");
                        distance = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Lenghth of Time in Minutes ");
                        LengthOfTime = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the day: ");
                                dateTimeday = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the month: ");
                                dateTimemonth = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the year: ");
                                dateTimeyear = Convert.ToInt32(Console.ReadLine());
                              Cycling cycli =  new Cycling(new DateTime(dateTimeyear, dateTimemonth,dateTimeday), LengthOfTime, cyclingSpeed);
                                cycli.DisplayexerciseSummary();
                        break;
                    case "3":
                         Console.Write("Enter the Distance Covered In KM ");
                        cyclingSpeed = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Lenghth of Time in Minutes ");
                        LengthOfTime = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the day: ");
                                dateTimeday = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the month: ");
                                dateTimemonth = Convert.ToInt32(Console.ReadLine());
                                 Console.Write("Enter the year: ");
                                dateTimeyear = Convert.ToInt32(Console.ReadLine());
                               Running run =  new Running(new DateTime(dateTimeyear, dateTimemonth,dateTimeday), LengthOfTime, distance);
                                run.DisplayexerciseSummary();
                                
                        break;
                
                    case "4":
            
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
        
    }
}
}
}

