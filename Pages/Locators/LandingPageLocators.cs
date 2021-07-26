using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;

namespace WizeFramework.Pages.Locators
{
    public static class LandingPageLocators
    {
        public static WebLocator LoginButton => WebLocator.Create(By.CssSelector("button[type='button']"), "Login button");
    }
}
