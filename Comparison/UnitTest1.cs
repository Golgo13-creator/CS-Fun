using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOps()
        {
            int age = 25;
            string userName = "Nick";
            bool equals = age == 41;
            Console.WriteLine(equals);
            bool userIsFrank = userName == "Frank";
            if (userName == "Nick")
            {
                Console.WriteLine("Almost done for the day.");
            }
            Console.WriteLine(userIsFrank);
            bool notEqual = age != 100;
            Console.WriteLine($"User is not 100: {notEqual}");
            bool userIsNotJuandice = userName != "Juandice";

            List<string> firstList = new List<string>();
            firstList.Add(userName);
            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listIsEqual = firstList == secondList;
            Console.WriteLine(listIsEqual);

            bool lessThan = age < 66;
            bool greaterThan = age > 12;
            bool greaterThanOrEqualTo = age >= 12;
            bool lessThanOrEqualTo = age <= 12;
            Console.WriteLine(lessThanOrEqualTo);
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;


            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine("True or True: ", tOrT);
            Console.WriteLine("True or False: ", tOrF);
            Console.WriteLine("False or True: ", fOrT);
            Console.WriteLine("False or False: ", fOrF);

            bool andValue = greaterThan && orValue;

            bool tandT = trueValue && trueValue;
            bool tandF = trueValue && falseValue;
            bool fandT = falseValue && trueValue;
            bool fandF = falseValue && falseValue;

            Console.WriteLine("True and True", tandT);
            Console.WriteLine("True and False", tandF);
            Console.WriteLine("False and True", fandT);
            Console.WriteLine("False and False", fandF);
         }
    }
}
