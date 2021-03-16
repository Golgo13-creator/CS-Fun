using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToDir_ShouldGetCorrectBoolean()
        {
            //AAA -> Arrange, Act Assert

            //Arrange -> overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act -> Get/ run the code to test
            bool addResult = repository.AddContentToDir(content);

            //Assert --> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);
        }
        //testing the read method
        [TestMethod]
        public void GetDir_ShouldReturnCorrectCollection()
        {
            //arrange
            //creating the content
            StreamingContent content = new StreamingContent();
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //adding to the repo(content)

            repo.AddContentToDir(content);

            //act
            //store list of streaming content w/n a variable
            List<StreamingContent> contents = repo.GetContent();

            //looks through our entire list and returns true if there is content
            bool directoryHasContent = contents.Contains(content);

            //assert
            Assert.IsTrue(directoryHasContent);
        }
        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //This is the arrange part
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            //we make a new movie here
            _content = new StreamingContent("Rubber", "A car tire comes to life", MaturityRating.R, GenreType.Drama, 5.8d);
            //now the movie is in our 'database' (list)
            _repo.AddContentToDir(_content);
        }
        // retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange... already done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            StreamingContent theFailure = _repo.GetContentByTitle("Rubber-duck");
            //Assert
            Assert.AreEqual(_content, searchResult);
        }
        //test update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange -> updated version of movie
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tire comes to life", MaturityRating.R, GenreType.Drama, 9.8);
            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }
        //Test the delete method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");
            //Act
            bool removeResult = _repo.DeleteExistingContent(content);
            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
