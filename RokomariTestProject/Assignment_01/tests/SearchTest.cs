using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using RokomariTestProject.Assignment_01.tests.LogIn;
using System.Threading;

namespace RokomariTestProject.Assignment_01.tests.Search_Cart
{
    public class SearchTest : SignInTest
    {

        [Test]
        public void Search()
        {
             int waitingTime = 200;

            // Search box
            var textSearch = webDriver.FindElement(By.Id("js--search"));
            // Search box operation
            textSearch.Click();
            textSearch.SendKeys("Harpercollins");

            // Search Button
            var SeachButton = webDriver.FindElement(By.ClassName("btn"));

            //operation
            SeachButton.Click();

            Thread.Sleep(waitingTime);

        }
    
    }

   
    public class CartTest : SignInTest
    {

        [Test]
        public void CrtTest()
        {
            int waitingTime = 200;

            // Search
            var CartButton = webDriver.FindElement(By.Id("cart-icon"));

            CartButton.Click();
            
            Thread.Sleep(waitingTime);

        }

    }
}