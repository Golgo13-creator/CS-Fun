using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTest
    {
        [TestMethod]
        public void WhileLoops()
        {
            //Setup
            int total = 1;
            while (total != 10) 
            {
                Console.WriteLine(total);
                total = total + 1;
            }
            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }
                total++;
            }
            Random random = new Random();
            int someCount;
            bool keepLooping = true;
            while (keepLooping)
            {
                someCount = random.Next(0, 20); //range = 0-19
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }                   
        }
        [TestMethod]
        public void forLoops()
        {
            int studentCount = 21;
            //init conditional increment
            for (int  i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "adam", "justin", "josh", "mira", "kaiser", "phil" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "adam", "justin", "josh", "mira", "kaiser", "phil" };
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }
            //string is an array of char
            string myName = "Richard Pryor Paul Mooney George Carlin";
            foreach(char letter in myName)
            {
                Console.WriteLine(letter);
            }
        }
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false");
            } while (false);

            while (true)
            {
                Console.WriteLine("My while condition is not false");
            };
        }
    }
}
