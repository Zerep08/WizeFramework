using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace WizeFramework.Extensions
{
    public class WebElement : IWebElement
    {
        public readonly IWebElement Element;
        private readonly WebLocator Locator;
        private readonly WebDriverWait WebDriverWait;

        public WebElement(IWebElement element, WebLocator locator, WebDriverWait webDriverWait)
        {
            Element = element;
            Locator = locator;
            WebDriverWait = webDriverWait;
        }
        public string TagName => Element.TagName;

        public string Text => Element.Text;

        public bool Enabled => Element.Enabled;

        public bool Selected => Element.Selected;

        public Point Location => Element.Location;

        public Size Size => Element.Size;

        public bool Displayed => Element.Displayed;

        public void Clear()
        {
            WaitUntilIsVisible();
            Element.Clear();
        }

        public void Click()
        {
            WaitUntilIsVisible();
            WaitUntilIsClickable();
            Element.Click();
        }

        public IWebElement FindElement(By by)
        {
            return Element.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Element.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return Element.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return Element.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            WaitUntilIsVisible();
            Element.SendKeys(text);
        }

        public void Submit()
        {
            WaitUntilIsVisible();
            Element.Submit();
        }

        public void WaitUntilIsVisible()
        {
            Action waitUntilVisible = () => WebDriverWait.Until(ExpectedConditions.ElementIsVisible(Locator.Query));
            waitUntilVisible.Should().NotThrow<WebDriverTimeoutException>($"{Locator.Name} found");
        }

        private void WaitUntilIsClickable()
        {
            Action waitUntilVisible = () => WebDriverWait.Until(ExpectedConditions.ElementToBeClickable(Locator.Query));
            waitUntilVisible.Should().NotThrow<WebDriverTimeoutException>($"{Locator.Name} is clickable");
        }
    }
}
