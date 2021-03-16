using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmChallenge
{
    class User
    {
        public string FirstName { get; set; } //property
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int ID { get; }
        public DateTime DateOfBirth { get; set; }
        public int Age 
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
        public User() {} //empty constructor

        public User(string firstName, string lastName, int id, DateTime dateOfBirth) //full constructor
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            DateOfBirth = dateOfBirth;
        }
        public string Username(string fullName)
        {
            FullName = fullName;
            fullName = FirstName + LastName;
            return FullName;
        }



    }
}
