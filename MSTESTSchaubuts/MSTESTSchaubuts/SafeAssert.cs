using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;


namespace MSTESTSchaubuts
{
    public static class  SafeAssert
    {
        public static void AreEqual(string expectedResult, IWebElement element)
        {

            string actualResult = element.Text.ToString();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
