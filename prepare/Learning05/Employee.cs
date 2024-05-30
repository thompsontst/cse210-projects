using System;
namespace week05Learning {

public abstract class Employee
{
  private string  _employeename;
  private string _employeeId;

public string GetEmployeeName(){
    return _employeename;
}
public void setEmployeeName(string employeeName)
{
_employeename = employeeName;
}
public string GetEmployeeId(){
    return _employeeId;
}
public void setEmployeeID(string employeeId)
{
_employeeId = employeeId;
}
//   public virtual float GetPay()
//   {
//     return -1;
//   }

public abstract float GetPay(); 

}
}

// a child class
