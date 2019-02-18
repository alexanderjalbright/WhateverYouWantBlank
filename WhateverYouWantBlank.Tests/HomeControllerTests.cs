using Microsoft.AspNetCore.Mvc;
using System;
using WhateverYouWantBlank.Controllers;
using Xunit;

namespace WhateverYouWantBlank.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new HomeController(); 

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
