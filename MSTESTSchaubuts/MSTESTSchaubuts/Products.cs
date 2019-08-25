using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;


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

            item = Driver.FindElement(By.LinkText("Signed prints on canvas gallery wrapped"));

            SafeAssert.AreEqual("Signed prints on canvas gallery wrapped", item);


            item = Driver.FindElement(By.LinkText("Original Acrylic Paintings"));
            SafeAssert.AreEqual("Original Acrylic Paintings", item);


            item = Driver.FindElement(By.LinkText("Original Graphite Drawings"));
            SafeAssert.AreEqual("Original Graphite Drawings", item);

            item = Driver.FindElement(By.LinkText("Original Watercolors"));
            SafeAssert.AreEqual("Original Watercolors", item);


            item = Driver.FindElement(By.LinkText("New Orleans"));
            SafeAssert.AreEqual("New Orlean", item);


            Thread.Sleep(5000);

            Driver.Navigate().Back();

            return Driver;
        }
    }
}
