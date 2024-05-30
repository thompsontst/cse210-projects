using System.Security.AccessControl;
namespace week05Learning {
public class HourlyEmployee : Employee
{
  private float _payRate = 0;
  private int _hoursWorked = 0;


public float GetPayRate()
        {
            return  _payRate;
        }

    public void SetPayRate(float payRate)
        {
           _payRate = payRate;
        }
public float GetHoursWorked()
        {
            return  _hoursWorked;
        }

    public void SetHoursWorked(int hoursWorked)
        {
          _hoursWorked = hoursWorked;
        }
               public override float GetPay()
  {         float monthlySalary = _hoursWorked * _payRate;
            return monthlySalary;
  } 
  

  // public override float CalculatePay()
  // {
  //   return rate * hours; // pay is calculated differently
  // }
  // public void EmployeeList() {
  //   List <Employee> employee = new List<Employee>();

  //   employee.Add(new Employee());
  //   employee.Add(new HourlyEmployee());

  //   foreach (Employee employees in employee)
  //   {
  //       float pay = employees.CalculatePay();
  //       Console.WriteLine(pay);
  //   }

  // }
}
}