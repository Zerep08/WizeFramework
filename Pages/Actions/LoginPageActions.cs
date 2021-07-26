using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;
using WizeFramework.Pages.Locators;

namespace WizeFramework.Pages.Actions
{
    public class LoginPageActions
    {
        private readonly WebDriver Driver;

        public LoginPageActions(WebDriver driver)
        {
            Driver = driver;
        }

        public LoginPageActions EnterUserName(string text)
        {
            Driver.GetElement(LoginPageLocators.UserName).SendKeys(text);
            return this;
        }

        public LoginPageActions EnterPassword(string text)
        {
            Driver.GetElement(LoginPageLocators.Password).SendKeys(text);
            return this;
        }

        public MyNotesPageActions ClickOnLoginButton()
        {
            Driver.GetElement(LoginPageLocators.LoginButton).Click();
            return new MyNotesPageActions(Driver);
        }
    }
}
