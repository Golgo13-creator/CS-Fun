using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if(userIsHungry)
            {
                Console.WriteLine("Eat something");
            }
            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16)
            {
                Console.WriteLine("Study more harder");
            }
        }
        [TestMethod]
        public void IfElseStatemens()
        {
            bool choresAreDone = false;
            if(choresAreDone)
            {
                Console.WriteLine("Have fun on the pitch!");
            }
            else
            {
                Console.WriteLine("Finish chores.");
            }
            string input = "7";
            int totalHours = int.Parse(input); //changes the "7" string to int
            if(totalHours >= 8)
            {
                Console.WriteLine("Sufficient rest");
            }
            else
            {
                Console.WriteLine("More rest required");
                if(totalHours < 4)
                {
                    Console.WriteLine("Much more rest needed");
                }
            }
            int age = 37;
            if(age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You are a kid");
                }
                else if(age > 0)
                {
                    Console.WriteLine("You are young to be on a computer");
                }
                else
                {
                    Console.WriteLine("You have not been born yet");
                }
            }
            if(age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }
            if(age > 65 || age < 18)
            {
                Console.WriteLine("Age is either greater than 65 or less than 18");
            }
            if(age == 21)
            {
                Console.WriteLine("Age is equal to 21");
            }
            if(age != 38)
            {
                Console.WriteLine("Age is not equal to 38");
            }
        }
    }
}
