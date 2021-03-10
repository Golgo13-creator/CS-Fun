using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;
            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;
        }
        [TestMethod]
        public void Characters()
        {
            char character = 'c';
            char symbol = '?';
            char numbers = '4';
            char space = ' ';
            char specialCharacter = '\n'; //escape character = newline
        }
        [TestMethod]
        public void Numbers() //max and min will always be the pos and neg of each other
        {
            byte byteExample = 255; 
            sbyte sByteExample = 127;
            short shortExample = 32767; 
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = 9223372036854775807;

            int a = 15;
            int b = -15;
            byte age = 30;
        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal deciExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(deciExample);
        }
        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Crossant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Cupcake;
            PastryType anotherOne = PastryType.Cake;
        }
        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1000, 4, 12);
        }
    }
}
