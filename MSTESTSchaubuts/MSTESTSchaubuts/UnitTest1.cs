using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;



namespace MSTESTSchaubuts
{
    [TestClass]
    public class UnitTest1
    {

        public static IWebDriver driver;
        public static IWebElement item;

        [TestMethod]

        public void TestMethod1()
        {


           driver = authenticate.initialise(driver, "Chrome");

            driver.Navigate().GoToUrl("https://schaubhuts.com");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Thread.Sleep(5000);

            IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
            {

                return item = driver.FindElement(By.LinkText("ACCEPT & CLOSE"));

            });

            item.Click();

        }

        [TestMethod]
        public void TestMethod2()
        {

            Products.ShopHereNow(driver);

        }

        [TestMethod]
        [TearDown]
        public void TestMethod3()
        {

            driver.Close();

        }

    }
}
