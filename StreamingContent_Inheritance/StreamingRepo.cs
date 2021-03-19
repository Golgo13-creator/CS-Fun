using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepo : StreamingContentRepository
    {
        //we will use the same _contentDir from StreamingContentRepository
        //Read -> Show
        public Show GetShowByTitle(string title)
        {
            //to find a specific show
            foreach (StreamingContent content in _contentDir)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }
        //Read -> Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDir)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }
        //Read get all
        public List<Show> GetAllShows()
        {
            //use this to add our shows -> 
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDir)
            {
                //if content is a type show
                if (content is Show)
                {
                    //add the show to the allShows list
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }
        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDir)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }
            }
            return allMovies;
        }
        /*public List<Movie> GetMoviesByRunTime(double runTime)
        {
            List<Movie> filmLength = new List<Movie>();
            foreach(StreamingContent content in _contentDir)
            {
                if(content is Movie && content. == runTime)
                {
                    filmLength.Add(content as Movie); 
                }
            }
            return null;
        }*/
    }
}
//Get by RunTime/AverageRunTime
//get shows with over x episodes
//get shows/movie by rating
