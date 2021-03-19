using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Test
{
    
    public class Calculator
    {
       
        
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        
        public decimal Add(decimal numThree, decimal numFour)
        {
            decimal sum = numThree + numFour;
            return sum;
        }
        
        public int Subtract(int numOne, int numTwo)
        {
            int diff = numOne - numTwo;
            return diff;
        }
        
        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }
        
        public int Divide(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            return quotient;
        }
    }
    [TestClass]
    public class CalcTest
    {
        private int numOne = 30; //only available inside of the class
        private int numTwo = 3;
        private decimal numThree = 3.14m;
        private decimal numFour = 3.66m;
        [TestMethod]
        public void TestingCalcMethod_ShouldReturnTrue()
        {
            Calculator calc = new Calculator();

            int sum = calc.Add(numOne, numTwo);
            int sub = calc.Subtract(numOne, numTwo);
            int prod = calc.Multiply(numOne, numTwo);
            int quo = calc.Divide(numOne, numTwo);
            decimal su = calc.Add(numThree, numFour);

            Assert.AreEqual(sum, (numOne + numTwo));
            Assert.AreEqual(sub, (numOne - numTwo));
            Assert.AreEqual(prod, (numOne * numTwo));
            Assert.AreEqual(quo, (numOne / numTwo));
            Assert.AreEqual(su, (numThree + numFour));
        }
    }
}
