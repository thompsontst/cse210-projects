using System;

class Program
{
    static void Main(string[] args)
    {
        // Askinig for the student's grade in percentage.
        Console.Write("What is your grade in Percentage? ");
        string studentGrade = Console.ReadLine();
        
        //converting string to integers
        int studentScore = int.Parse(studentGrade);
        string letter = "";
        string gradeSign = "";
        if (studentScore >= 90)
        {
            letter = "A";
        }
        else if (studentScore >= 80)
        {
            letter = "B";
        }
        else if (studentScore >= 70)
        {
            letter = "C";
        }
        else if (studentScore >= 60)
        {
           letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (studentScore%10 >= 7 && letter != "A" && letter != "F")
            {
                gradeSign = "+";
            }
        if (studentScore%10 > 3 &&  letter != "F")
            {
                gradeSign = "";
            }
        if (studentScore%10 < 3 &&  letter != "F")
            {
                gradeSign = "-";
            }

        Console.WriteLine($"Your Grade is {letter}{gradeSign}");
        if (studentScore >= 70)
        {
            Console.WriteLine("Congratulations!!! You have passed the Course");
        }
        else
        {
            Console.WriteLine("I have noticed your hardworked, though you did not make a pass this time, I am sure you will do better next semester.");
        }
    }
}