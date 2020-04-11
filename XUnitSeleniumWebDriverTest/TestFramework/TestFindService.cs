using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitSeleniumWebDriverTest.TestFramework
{
    class TestFindService
    {
        public static bool FindElementHeaderText(WebDriverWait wait, String ClassName, String TagName, String text)
        {
            WebItem Item = new WebItem("",ClassName,"",TagName);
            IWebElement element = TestFramework.FindWebElement(Item); 
            return wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public static IWebElement FindElementLinkHref(WebDriverWait wait, String ClassName, String XPath)
        {
            WebItem Item = new WebItem("", ClassName, XPath,"");
            IWebElement element = TestFramework.FindWebElement(Item);
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
