using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;
using WizeFramework.Pages.Locators;

namespace WizeFramework.Pages.Actions
{
    public class MyNotesPageActions
    {
        private readonly WebDriver Driver;

        public MyNotesPageActions(WebDriver driver)
        {
            Driver = driver;
        }

        public void MyNotesTextShouldBeDisplayed()
        {
            Driver.GetElement(MyNotesLocators.MyNotesTitle).WaitUntilIsVisible();
        }
    }
}
