using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WizeFramework.Extensions
{
    public class WebDriver : IWebDriver
    {
        public readonly IWebDriver Driver;
        private readonly WebDriverWait WebDriverWait;

        public WebDriver(IWebDriver driver, int timeout)
        {
            Driver = driver;
            var waitTimeout = TimeSpan.FromSeconds(timeout);
            var sleepInterval = TimeSpan.FromSeconds(1);
            WebDriverWait = new WebDriverWait(new SystemClock(), driver, waitTimeout, sleepInterval);
        }

        public string Url { get => Driver.Url; set => Driver.Url = value; }

        public string Title => Driver.Title;

        public string PageSource => Driver.PageSource;

        public string CurrentWindowHandle => Driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => Driver.WindowHandles;

        public void Close()
        {
            Driver.Close();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }

        public IWebElement FindElement(By by)
        {
           return Driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Driver.FindElements(by);
        }

        public WebElement GetElement(WebLocator locator)
        {
            Action waitUntilExist = () => WebDriverWait.Until(ExpectedConditions.ElementExists(locator.Query));
            waitUntilExist.Should().NotThrow<WebDriverTimeoutException>($"{locator.Name} exist");
            var element = Driver.FindElement(locator.Query);
            return new WebElement(element, locator, WebDriverWait);

        }

        public ReadOnlyCollection<IWebElement> GetElements(WebLocator locator)
        {
            Action waitUntilExist = () => WebDriverWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator.Query));
            waitUntilExist.Should().NotThrow<WebDriverTimeoutException>($"{locator.Name} exist");
            return Driver.FindElements(locator.Query);
        }

        public IOptions Manage()
        {
            return Driver.Manage();
        }

        public INavigation Navigate()
        {
            return Driver.Navigate();
        }

        public void Quit()
        {
            Driver.Quit();
        }

        public ITargetLocator SwitchTo()
        {
            return Driver.SwitchTo();
        }

        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
