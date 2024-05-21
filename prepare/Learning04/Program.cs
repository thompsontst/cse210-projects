using System;
namespace week04_demo {
class Program
{
    static void Main(string[] args)
    {
    Assignment assignment1 = new Assignment("Aniekan Thompson", "Banking");
    Console.WriteLine(assignment1.GetSummary());
    
    MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
    Console.WriteLine(assignment2.GetHomeWorkList());

    WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II by Mary Waters");
    Console.WriteLine(assignment3.GetWritingInformation());



    Student studentOne = new Student("Thompson", 242);
    string studentName = studentOne.GetName();
    int studentNumber = studentOne.GetNumber();
    
    Console.WriteLine("Enter Student Name? ");
    string StudentIdentity = Console.ReadLine();

    if (studentName == StudentIdentity) {
        Console.WriteLine ("Welcome, Please Enter your department");

    }
    else
        {
            Console.WriteLine("Invalid Identity");
        }
    
     Console.WriteLine("what is the name of the author");
     string bookauthor1 =  Console.ReadLine(); 
      Console.WriteLine("what is the title of the book? ");
     string booktitle1 =  Console.ReadLine(); 
      Book book1 = new Book();
     book1.SetAuthor(bookauthor1);
     book1.SetTitle(booktitle1);
    
     Console.WriteLine( book1.GetBookInfo());


 Console.WriteLine("what is the name of the author");
     string bookauthor2 =  Console.ReadLine(); 
      Console.WriteLine("what is the title of the book? ");
     string booktitle2 =  Console.ReadLine(); 
     Console.WriteLine("what is the Illustartor? ");
     string illustrator1 =  Console.ReadLine(); 
      PictureBook book2 = new PictureBook();
     book2.SetAuthor(bookauthor2);
     book2.SetTitle(booktitle2);
     book2.SetIllustrator(illustrator1);
    
     Console.WriteLine( book2.GetPictureBookInfo());


     Book book3 = new Book();
     Console.WriteLine(book3.GetBookInfo());

     PictureBook book4 = new PictureBook();
     Console.WriteLine(book4.GetPictureBookInfo());


    }
}
}