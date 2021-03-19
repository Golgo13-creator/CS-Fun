using RepositoryPatterns;
using StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Console
{
    public class ProgramUI
    {
        private readonly StreamingRepo _streamingRepo = new StreamingRepo();
        public void Run()
        {
            //examples of coding with intent
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                Console.Clear();//clears console buffer and console window of display info 
                Console.WriteLine("Enter the option selection number:\n" +
                    "1: Show all streaming content\n" +
                    "2: Find streaming content by title\n" +
                    "3: Add new content\n" +
                    "4: Remove streaming content\n" +
                    "5: Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    //default:
                      //  Console.WriteLine("Enter a valid number between 1 and 5\n" +
                        //"Press any key to continue");
                        //Console.ReadKey(); //obtains the next char or function key pressed by the user
                }
            }
        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent(); //instantiation, "new-up" example
            Console.WriteLine("Welcome to the Streaming Content Creator page");
            Console.WriteLine("Please enter a title:");
            content.Title = Console.ReadLine(); //take in user input and setting equal to content.Title
            Console.WriteLine("Please enter a description:");
            content.Description = Console.ReadLine();
            Console.WriteLine("Please enter a star rating (1-5):");
            content.StarRating = double.Parse(Console.ReadLine());
            Console.WriteLine("Select a maturity rating:\n" +
                "1: G\n" +
                "2: PG\n" +
                "3: TV_G\n" +
                "4: TV_Y\n" +
                "5: TV_PG\n" +
                "6: PG 13\n" +
                "7: R\n" +
                "8: NC_17\n" +
                "9: TV_14\n" +
                "10: TV_MA\n");
            string RatingForMaturity = (Console.ReadLine());
            switch (RatingForMaturity)
            {
                case "1":
                    content.RatingForMaturity = MaturityRating.G;
                    break;
                case "2":
                    content.RatingForMaturity = MaturityRating.PG;
                    break;
                case "3":
                    content.RatingForMaturity = MaturityRating.TV_G;
                    break;
                case "4":
                    content.RatingForMaturity = MaturityRating.TV_Y;
                    break;
                case "5":
                    content.RatingForMaturity = MaturityRating.TV_PG;
                    break;
                case "6":
                    content.RatingForMaturity = MaturityRating.PG_13;
                    break;
                case "7":
                    content.RatingForMaturity = MaturityRating.R;
                    break;
                case "8":
                    content.RatingForMaturity = MaturityRating.NC_17;
                    break;
                case "9":
                    content.RatingForMaturity = MaturityRating.TV_14;
                    break;
                case "10":
                    content.RatingForMaturity = MaturityRating.TV_MA;
                    break;
                
            }
            Console.WriteLine("Select a Genre Type: please select " +
                "1: Action\n" +
                "2: Horror\n" +
                "3: Martial_Arts\n" +
                "4: Documentary\n" + 
                "5: Romance\n" + 
                "6: Drama\n" + 
                "7: Action\n" + 
                "8: RomCom\n");
            string genreInput = Console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.Genre = (GenreType)genreID;

            _streamingRepo.AddContentToDir(content);
        }
        private void ShowAllContent() 
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContent();
            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Maturity Rating: {content.RatingForMaturity}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Please enter a Title:");
            string title = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(title);
            if(content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine($"Invalid Title. Could not find results {title}");
            }
            Console.WriteLine("Press any key to continue...");
        }
        private void RemoveContentFromList()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContent();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentID = int.Parse(Console.ReadLine());
            int targetIndex = targetContentID - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];

                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} was successfully removed.");
                }
                else
                {
                    Console.WriteLine("Sorry. Something went wrong.");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Maturity Rating: {content.RatingForMaturity}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n");
        }
        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tire comes to life", MaturityRating.NC_17, GenreType.Action, 5.6);
            StreamingContent toystory = new StreamingContent("Toy Story", "Toy Movie", MaturityRating.G, GenreType.Action, 8.8);
            StreamingContent starwars = new StreamingContent("Star Wars", "Mace Windu", MaturityRating.PG_13, GenreType.Action, 8.9);

            _streamingRepo.AddContentToDir(rubber);
            _streamingRepo.AddContentToDir(toystory);
            _streamingRepo.AddContentToDir(starwars);
        }
        
        

    }
}
