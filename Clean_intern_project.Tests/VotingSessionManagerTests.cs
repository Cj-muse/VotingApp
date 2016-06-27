using System.Collections.Generic;
using Clean_intern_project.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clean_intern_project.Tests
{
    [TestClass]
    public class VotingSessionManagerTests
    {
        [TestMethod]
        public void CreateSessionShouldSetSessionTitle()
        {
            // arrange
            VotingSessionManager manager = new VotingSessionManager();

            // act
            VotingSessionObject votingSessionObject = manager.CreateSession("my session name", "blah haha", new Dictionary<string, VotingSessionObject>());

            // assert
            Assert.AreEqual("my session name", votingSessionObject.SessionTitle);
        }
    }
}
