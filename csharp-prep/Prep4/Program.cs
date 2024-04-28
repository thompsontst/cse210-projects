using System;

class Program
{
    static void Main(string[] args)
    {
        {
        List<int> numbers = new List<int>();
        
       
        int enterNumber = -1;
        while (enterNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            
            enterNumber = int.Parse(Console.ReadLine());
            
            
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }

        // to sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

    // to find average 
        float averageNumber = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {averageNumber}");

       
        // to find max.
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                // if this number is greater than the max, we have found the new max!
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
    }
}
}