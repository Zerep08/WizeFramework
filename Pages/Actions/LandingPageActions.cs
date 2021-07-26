using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;
using WizeFramework.Pages.Locators;

namespace WizeFramework.Pages.Actions
{
    public class LandingPageActions
    {
        private readonly WebDriver Driver;

        public LandingPageActions(WebDriver driver)
        {
            Driver = driver;
        }

        public LoginPageActions ClickOnLoginButton()
        {
            Driver.GetElement(LandingPageLocators.LoginButton).Click();
            return new LoginPageActions(Driver);
        }
    }
}
