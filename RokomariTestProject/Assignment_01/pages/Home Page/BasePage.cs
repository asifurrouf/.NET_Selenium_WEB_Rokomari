using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace RokomariTestProject.Assignment_01.pages.Home_Page
{
    public class BasePage
    {
        public IWebDriver webDriver; 

        [OneTimeSetUp]
        public void open()
        {
            
            webDriver = new ChromeDriver(@"D:\Drive");

            //Navigate to site
            webDriver.Navigate().GoToUrl("https://www.rokomari.com/book");

            webDriver.Manage().Window.Maximize();

            

        }

        [OneTimeTearDown]
        public void close()
        {
            webDriver.Close(); 
        }


    }
}
