using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace MSTESTSchaubuts
{
    public static class authenticate
    {
   
        public static IWebDriver initialise(IWebDriver Driver, string BrowserDriver)
        {

            Driver = new ChromeDriver(@"C:\drivers\");

            //todo may code other browsers here

            return Driver;
        }

        public static void login(IWebDriver Driver)
        {
           // Driver 

        }

        public static void logout(IWebDriver Driver)
        {

        }

    }
}
