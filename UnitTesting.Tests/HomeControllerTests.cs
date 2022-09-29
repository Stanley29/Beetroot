using Microsoft.AspNetCore.Mvc;
using UnitTesting.Controllers;
using Xunit;

namespace UnitTesting.Tests;

public class HomeControllerTests
{
    [Fact]
    public void IndexViewDataMessage()
    {
        // Arrange
        HomeController controller = new HomeController();
        // Act
        ViewResult result = controller.Index() as ViewResult;
        // Assert
        Assert.Equal("Hello world!", result?.ViewData["Message"]);
    }
    [Fact]
    public void IndexViewResultNotNull()
    {
        // Arrange
        HomeController controller = new HomeController();
        // Act
        ViewResult result = controller.Index() as ViewResult;
        // Assert
        Assert.NotNull(result);
    }
    [Fact]
    // [Theory]
    public void IndexViewNameEqualIndex()
    {
        // Arrange
        HomeController controller = new HomeController();
        // Act
        ViewResult result = controller.Index() as ViewResult;
        // Assert
        Assert.Equal("Index", result?.ViewName);
    }
}