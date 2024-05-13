public class Account
{
    public int _balance = 0;
    public void Deposit(int amount)
{
    _balance = _balance + amount;
}
}

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
 public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string lastName)
    {
        _firstName = lastName;
    }
public string GetLastName()
    {
        return _firstName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, Yours" + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }

}


public class Fraction
{
    private int _button;
    private int _top;

    public Fraction ()
    {
    
    int _button = 1;
    int _top = 1;
    }
public Fraction (int numerator, int denominator)
    {
    
    int _top = numerator;
    int _button = denominator;
    }
    public int GetTopNumber()
    {
        return _top;
    }
 public int SetTopNumber(int numerator)
    {
       return  _top = numerator;
    }
    public int GetButtonNumber()
    {
        return _button;
    }
 public int SetButtonNumber(int denominator)
    {
       return  _top = denominator;
    }
       public double GetFraction()
    {
         return (double)_button / (double)_top;
    }
}















