using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WizeFramework.Extensions
{
    public class WebLocator
    {
        public By Query;
        public string Name;
        private WebLocator(By query, string name)
        {
            Query = query;
            Name = name;
        }

        public static WebLocator Create(By query, string name) => new WebLocator(query, name);
    }
}
