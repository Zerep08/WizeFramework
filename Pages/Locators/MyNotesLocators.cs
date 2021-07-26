using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;

namespace WizeFramework.Pages.Locators
{
    public static class MyNotesLocators
    {
        public static WebLocator MyNotesTitle => WebLocator.Create(By.CssSelector("div[id='my-notes-page'] h2"), "My Notes title");
    }
}
