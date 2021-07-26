using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WizeFramework.Extensions;

namespace WizeFramework.Tests.Base
{
    public class BaseTest
    {
        public WebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new WebDriver(new ChromeDriver(), 6);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
