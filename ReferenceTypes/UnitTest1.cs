using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;
            string declared;
            declared = "this is initialized.";
            string declareAndInitialize = "This is both declaring and initializing.";
            string firstName = "Duke";
            string lastName = "Togo";
            string fullName = firstName + " " + lastName; //concatenation
            string interpolateFullName = $"{firstName} {lastName}"; //interpolation
            string compositeFullName = string.Format("Full Name: {0} {1}", firstName, lastName); //composite formatting
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(interpolateFullName);
            Console.WriteLine(compositeFullName);
        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";
            string[] stringArray = { "Hello", "World!", "Why", "Is it", "always", stringExample };
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();
            listOfStrings.Add("First string for our list.");
            listOfInts.Add(987654321);
            Console.WriteLine(listOfInts[0]);

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");
            string firstItem = firstInFirstOut.Dequeue(); //selects first item in the queue
            Console.WriteLine(firstItem);

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(4, "Agent"); //4 is the key and "agent" is the value
            string valueFour = keyAndValue[4]; //calling "agent" with the key of 4
            Console.WriteLine(valueFour); //printing the value indexed by the key

            SortedList<int, string> sortedKeyandValue = new SortedList<int, string>(); //combo of list and dictionary
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }

    }
}

