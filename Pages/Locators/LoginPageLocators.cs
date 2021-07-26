using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;

namespace WizeFramework.Pages.Locators
{
    public static class LoginPageLocators
    {
        public static WebLocator UserName => WebLocator.Create(By.CssSelector("input[placeholder='Username']"),"User name field");
        public static WebLocator Password => WebLocator.Create(By.CssSelector("input[placeholder='Password']"),"Password field");
        public static WebLocator LoginButton => WebLocator.Create(By.CssSelector(".button-login"),"Login button");
    }
}
