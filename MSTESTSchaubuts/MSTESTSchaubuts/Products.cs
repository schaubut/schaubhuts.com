using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace MSTESTSchaubuts
{
    public static class Products
    {

        public static IWebDriver ShopHereNow(IWebDriver Driver)
        {
            Thread.Sleep(5000);

            IWebElement item;

            item = Driver.FindElement(By.LinkText("SHOP HERE NOW"));

            item.Click();

            Thread.Sleep(5000);

            Driver.Navigate().Back();

            return Driver;
        }
    }
}
