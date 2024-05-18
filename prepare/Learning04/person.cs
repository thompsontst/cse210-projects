using System.Reflection.Metadata.Ecma335;
namespace week04_demo{
 public class Person {
    private  string _name;
    public   Person (string name)
    {
        string _name = name;
    }

    public string GetName()
    {
            return _name;
    }
}
public class Student : Person 
{
    private int _number;
    public Student(string name, int number) : base(name)
    {
        _number = number;
    }
    public int GetNumber()
{
    return _number;
}
}
}
