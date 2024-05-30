using System;
namespace week05Learning {
    public class SalaryEmployee:Employee
    {
        private float _annualSalary = 0;

        public float GetannualSalry()
        {
            return  _annualSalary;
        }

    public void SetannualSalry(float annualSalary)
        {
            _annualSalary = annualSalary;
        }

          public override float GetPay()
  {         float monthlySalary = _annualSalary/12;
            return monthlySalary;
  }  
    }
}