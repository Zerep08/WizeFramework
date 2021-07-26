using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Pages.Actions;
using WizeFramework.Tests.Base;

namespace WizeFramework.Tests
{
    public class LoginTest : BaseTest
    {
        LandingPageActions LandingPage;
        [SetUp]
        public void BeforeEachTest()
        {
            Driver.NavigateTo("http://testapp.galenframework.com/");
            LandingPage = new LandingPageActions(Driver);
        }

        [Test]
        public void User_Should_Be_Login()
        {
            LandingPage.ClickOnLoginButton()
                       .EnterUserName("testuser@example.com")
                       .EnterPassword("test123")
                       .ClickOnLoginButton()
                       .MyNotesTextShouldBeDisplayed();
        }
    }
}
