using System;
using System.Security.Cryptography.X509Certificates;
namespace week05Learning {

class Program
{
    static void Main(string[] args)
    {
    //     HourlyEmployee hEmployee = new HourlyEmployee();
    //     hEmployee.setEmployeeName("Ani");
    //     hEmployee.setEmployeeID("1234rt");
    //     hEmployee.SetPayRate(6);
    //     hEmployee.SetHoursWorked(80);

    //  SalaryEmployee sEmployee = new SalaryEmployee();
    //     sEmployee.setEmployeeName("Aniekan");
    //     sEmployee.setEmployeeID("1234rtut");
    //     sEmployee.SetannualSalry(9000);
        
    //     DisplayEmployeesInformation(hEmployee);
    //     DisplayEmployeesInformation(sEmployee);

    // List <Employee> employee = new List<Employee>();

    // employee.Add(sEmployee);
    // employee.Add(hEmployee);
    
    // foreach (Employee employees in employee)
    // {
    //     float pay = employees.GetPay();
    //     Console.WriteLine(pay);
    // }
                List <Shape> shapes = new List<Shape>();

                    Squares area1 = new Squares("Red", 13);
                    area1.GetArea();
                    shapes.Add(area1);

                     Rectangle area2 = new Rectangle ("blue", 13, 12);
                    area2.GetArea();
                    shapes.Add(area2);


                      Circle area3 = new Circle ("green",  12);
                    area2.GetArea();
                    shapes.Add(area3);

                    foreach (Shape sh in shapes)
                    {
                        string color = sh.GetColor();

                        double area = sh.GetArea();

                        Console.WriteLine($"the color is {color} and the area is {area}");
                    }

                    
                

    
            
    }
            
        public static void DisplayEmployeesInformation(Employee e) 

    {
        float pay = e.GetPay();
        Console.WriteLine($"{e.GetEmployeeName()}, Your Pay is {pay}");

    }  

     public static void DisplayShapes(Shape s) 

    {
        double myShapes = s.GetArea();
        Console.WriteLine($"{s.GetColor()}, Your Pay is {myShapes}");

    }   
            }

}