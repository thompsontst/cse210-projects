using System;
namespace week05Learning {

public  class Squares: Shape
{
private double _side;

public Squares(string color, double side): base (color)  
{
    
    _side = side;
}
public override double GetArea()
{
    double areaOfASquare = _side * _side;

    return areaOfASquare;
}
} 

}