using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitSeleniumWebDriverTest.TestFramework
{
    class TestFramework
    {
        static IWebDriver _WebDriver;

        public static IWebDriver WebDriver
        {
            get
            {
                if (_WebDriver == null)
                    _WebDriver = new ChromeDriver(@"C:\Users\overl\source\repos\XUnitSeleniumWebDriverTest\XUnitSeleniumWebDriverTest\bin\Debug\netcoreapp2.1");
                return _WebDriver;
            }
        }

        public static IWebElement FindWebElement(WebItem webItem)
        {
            if (webItem.ID != "")
                return WebDriver.FindElement(By.Id(webItem.ID));
   
            if (webItem.ClassName != "")
                return WebDriver.FindElement(By.ClassName(webItem.ClassName));
    
            if (webItem.XPathQuery != "")
                return WebDriver.FindElement(By.XPath(webItem.XPathQuery));

            if (webItem.TagName != "")
                return WebDriver.FindElement(By.TagName(webItem.TagName));

            return null;
        }
    }
}
