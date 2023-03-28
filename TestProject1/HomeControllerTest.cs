using Microsoft.AspNetCore.Mvc;
using Moq;
using serverside.Controllers;
using serverside.Core.Errors;
using serverside.Response;
using serverside.Services.Weather;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class HomeControllerTest
    {
        HomeController _homeController;

        public HomeControllerTest(HomeController homeController) 
        {
            _homeController = homeController;
        }

        [Fact]
        public async void Get_WithoutParame_Ok()
        {
            var result = await  _homeController.GetCountry() as OkObjectResult;

            Assert.Equal(200, result.StatusCode);
        }

    }
}
