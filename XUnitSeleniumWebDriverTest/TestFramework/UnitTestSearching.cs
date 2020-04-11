using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Xunit;
using XUnitSeleniumWebDriverTest.TestFramework;

namespace XUnitSeleniumWebDriverTest.TestFramework
{
    public class UnitTestSearching
    {
        [Fact]
        public void TestUnitFindHeaderText()
        {

            TestFramework.WebDriver.Url = @"https://gemsdev.ru";

            TestFramework.WebDriver.FindElement(By.LinkText("Продукты")).Click();

            IWebElement element = TestFramework.FindWebElement(new WebItem("","","","footer"));
            //Пролистываем до низу, чтобы изменить все элементы Hidden -> Visible
            Actions actions = new Actions(TestFramework.WebDriver);
            actions.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
            actions.MoveToElement(element).Click();

            WebDriverWait wait = new WebDriverWait(TestFramework.WebDriver, TimeSpan.FromSeconds(10));

            List<bool> result = new List<bool>();
            //Пополнения 
            result.Add(TestFindService.FindElementHeaderText(wait, "my-150","h1", "GeoMeta"));
            result.Add(TestFindService.FindElementHeaderText(wait, "gos-system", "h2", "Государственная система обеспечения градостроительной деятельности"));
            result.Add(TestFindService.FindElementHeaderText(wait, "urban-analytics", "h2", "Городская аналитика"));
            result.Add(TestFindService.FindElementHeaderText(wait, "other-products", "h2", "Другие наши продукты"));

            Assert.DoesNotContain(false, result);
        }

        [Fact]
        public void TestUnitFindLink()
        {
            TestFramework.WebDriver.Url = @"https://gemsdev.ru";

            TestFramework.WebDriver.FindElement(By.LinkText("Продукты")).Click();

            IWebElement element = TestFramework.WebDriver.FindElement(By.TagName("footer"));

            //Пролистываем до низу, чтобы изменить все элементы Hidden -> Visible
            Actions actions = new Actions(TestFramework.WebDriver);
            actions.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
            actions.MoveToElement(element).Click();

            WebDriverWait wait = new WebDriverWait(TestFramework.WebDriver, TimeSpan.FromSeconds(10));

            element = TestFindService.FindElementLinkHref(wait, "gos-system", ".//a[contains(@href,'https://xn--c1aaceme9acfqh.xn--p1ai/')]");

            Assert.NotNull(element);
        }
    }
}
