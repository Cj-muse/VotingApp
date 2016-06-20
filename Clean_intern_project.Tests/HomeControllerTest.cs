using Clean_intern_project.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clean_intern_project.Tests
{
    [TestClass]
    public class HomeControllerTest 
    {
        [TestMethod]
        public void WelcomeMessageTest()
        {
            // Arrange 
            HomeController controller = new HomeController();
            string message;

            // Act
            message = controller.WelcomeMessage();

            // Assert
            Assert.AreEqual(message, "Welcome to Conner's App!");
        }
    }
}
