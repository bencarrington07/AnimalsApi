using AnimalsApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace AnimalsApi.Tests;

[TestClass]
public class AnimalsControllerTests
{
    private Mock<ILogger> _mockLogger;
    private AnimalsController _animalsController;

    [TestInitialize]
    public void TestInitialize()
    {
        _mockLogger = new Mock<ILogger>();
        _animalsController = new AnimalsController(_mockLogger.Object);
    }

    [TestMethod]
    public void AnimalsGetReturnsCorrectly()
    {
        var apiCall = _animalsController.Get();
        Assert.IsNotNull(apiCall);
    }
}
