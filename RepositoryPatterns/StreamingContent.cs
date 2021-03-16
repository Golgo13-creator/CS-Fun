using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{   public enum MaturityRating { G, PG, TV_G, TV_Y, TV_PG, PG_13, R, NC_17, TV_14, TV_MA}

    public enum GenreType { Horror=1, Martial_Arts, Documentary, Romance, Drama, Action, RomCom }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating RatingForMaturity { get; set; }
        public GenreType Genre { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (RatingForMaturity)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                        return false;
                }//default neeed without the if..else statement
                if ((int)RatingForMaturity > 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public StreamingContent()
        {

        }
        public StreamingContent(string title, string description, MaturityRating ratingForMaturity, GenreType genre, double starRating)
        {
            Title = title;
            Description = description;
            RatingForMaturity = ratingForMaturity;
            Genre = genre;
            StarRating = starRating;
            
        }        
    }
}
