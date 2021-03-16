using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
    //CRUD 
    //Create, Read, Update, Delete
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDir = new List<StreamingContent>();
        //create
        public bool AddContentToDir(StreamingContent content)
        {
            int StartingCount = _contentDir.Count;
            _contentDir.Add(content);
            bool wasAdded = (_contentDir.Count > StartingCount) ? true : false; //ternary
            return wasAdded;
        }
        //read
        public List<StreamingContent> GetContent()
        {
            return _contentDir; //gets all content
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDir)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content; //gets content by title
                }
            }
            return null; //not a best practice
        }
        public StreamingContent GetContentByDescription(string description)
        {
            foreach(StreamingContent descript in  _contentDir)
            {
                if(descript.Description.ToLower() == description.ToLower())
                {
                    return descript;
                }
            }
            return null;
        }
        public StreamingContent GetContentByStarRating(double starRating)
        {
            foreach (StreamingContent star in _contentDir)
            {
                if (star.StarRating == starRating)
                {
                    return star;
                }
            }
            return null;
        }
        public StreamingContent GetContentByRatingForMaturity(MaturityRating ratingForMaturity)
        {
            foreach (StreamingContent mature in _contentDir)
            {
                if (mature.RatingForMaturity == ratingForMaturity)
                {
                    return mature;
                }
            }
            return null;
        }
        public StreamingContent GetContentByGenre(GenreType genre)
        {
            foreach (StreamingContent gen in _contentDir)
            {
                if (gen.Genre == genre)
                {
                    return gen;
                }
            }
            return null;
        }
        /*public StreamingContent GetContentByFamilyFriendly()
        {
            foreach (StreamingContent fam in _contentDir)
            {
                if (fam.IsFamilyFriendly == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False"); 
                }
            }
        }*/

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.RatingForMaturity = newContent.RatingForMaturity;
                oldContent.Genre = newContent.Genre;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDir.Remove(existingContent);
            return deleteResult;
        }
    }
}
//Challenge
//get by other params
//get by rating
//get by family friendly
