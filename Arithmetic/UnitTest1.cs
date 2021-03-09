using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;
            //Addition '+'
            int sum = a + b;
            Console.WriteLine(sum);
            sum += 3;
            Console.WriteLine(sum);
            //Subtraction '-'
            int difference = a - b;
            difference -= 3;
            Console.WriteLine(difference);
            //Multiplication '*'
            int product = a * b;
            product *= 3;
            Console.WriteLine(product);
            //Division '/'
            int quotient = a / b;
            Console.WriteLine(quotient);
            //Modulus
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1970, 12, 31);

            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);


        }
    }
}
