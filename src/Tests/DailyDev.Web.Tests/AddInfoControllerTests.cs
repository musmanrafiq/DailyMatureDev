using DailyDev.Web.Controllers.Info;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DailyDev.Web.Tests
{
    public class AddInfoControllerTests
    {
        [Fact]
        public void AddInfoController_ShouldAbleToAddInfo()
        {
            // arrange
            var addInfoController = new AddInfoController();

            // act
            var result =  addInfoController.Add(new InfoModel());

            // assert
            Assert.IsType<OkObjectResult>(result as OkObjectResult);

        }
    }
}