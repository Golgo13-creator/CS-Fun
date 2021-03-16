using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator
    {//return type is always a value type
        public int Add(int numOne, int numTwo) //access modifier, return type, method signature(parameters)
        {
            int sum = numOne + numTwo;
            return sum; 
        }
        public double Add(double numOne, double numTwo) //overloaded method for add
        {
            double sum = numOne + numTwo;
            return sum;
        }
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
