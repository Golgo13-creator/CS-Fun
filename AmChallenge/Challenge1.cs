using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AmChallenge
{
    [TestClass]
    public class Challenge1
    {
        string word = "Supercalifragilisticexpialidocious";

        [TestMethod]
        public void Word()
        {
            foreach(char w in word)
            {
                Console.WriteLine(w);
            }   
        }
        [TestMethod]
        public void Wordplay()
        {
            foreach (char w in word)
            {
                if (w != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine(w);
                }
            }
        }
        [TestMethod]
        public void Bonus1()
        {
           int bonus = word.Length;
            Console.WriteLine(bonus);
        }
        [TestMethod]
        public void Bonus2()
        {
            foreach(char w in word)
            {
                if(w == 'i')
                {
                    Console.WriteLine(w);
                }
                else if(w == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }

    }
}
