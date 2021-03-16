using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class Movie : StreamingContent
    {
        //the properties of this class comes from the StreamingContent class
        public double RunTime { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, MaturityRating ratingForMaturity, GenreType genre, double starRating, double runTime)
            :base(title, description, ratingForMaturity, genre, starRating) //passes the variables without having to put in the constructor 
        {
            RunTime = runTime;
        }
    }
}
