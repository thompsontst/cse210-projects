using System;

class Program
{
    static void Main(string[] args)
    {
        Account savings = new Account();
        savings._balance = 50;
        savings.Deposit(100);
        Console.WriteLine(savings._balance);
    
    Console.Write("what is your Title? " );
    string myTitle = Console.ReadLine();
    
        Console.Write("what is your First name? " );
    string myFirstName = Console.ReadLine();

        Console.Write("what is your Last name? " );
    string myLastName = Console.ReadLine();

    Person myPerson = new Person(myTitle, myFirstName, myLastName);
    Console.WriteLine(myPerson.GetFormalSignature());
    }
}