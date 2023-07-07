using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Basecode.Test
{
    public class UnitTest1
    {
        [Fact]
        public void JobOpeningController_AddTest_DataResultFalse()
        {
            //Arrange
            var serviceMock = new Mock<IJobOpeningService>();
            JobOpeningViewModel jobOpeningViewModel = new JobOpeningViewModel();
            var controller = new JobOpeningController(serviceMock.Object);

            serviceMock.Setup(s => s.CheckValidTitle(jobOpeningViewModel)).Returns(new JobOpeningErrorHandler.LogContent { Result = false }) ;
            //Act
            var result = controller.Add(jobOpeningViewModel);
            //Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }
        [Fact]
        public void JobOpeningController_AddTest_DataResultTrue()
        {
            //Arrange
            var serviceMock = new Mock<IJobOpeningService>();
            JobOpeningViewModel jobOpeningViewModel = new JobOpeningViewModel();
            var controller = new JobOpeningController(serviceMock.Object);

            serviceMock.Setup(s => s.CheckValidTitle(jobOpeningViewModel)).Returns(new JobOpeningErrorHandler.LogContent { Result = true });
            //Act
            var result = controller.Add(jobOpeningViewModel);
            //Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }
        [Fact]
        public void JobOpeningController_IndexTest()
        {
            //Arrange
            var serviceMock = new Mock<IJobOpeningService>();
            JobOpeningViewModel jobOpeningViewModel = new JobOpeningViewModel();
            var controller = new JobOpeningController(serviceMock.Object);

            serviceMock.Setup(s => s.CheckValidTitle(jobOpeningViewModel)).Returns(new JobOpeningErrorHandler.LogContent { Result = true });
            //Act
            var result = controller.Index();
            //Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }
    }
}