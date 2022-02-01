using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using RokomariTestProject.Assignment_01.tests.LogIn;
using System.Threading;

namespace RokomariTestProject
{
    public class TopBarTests : SignInTest
    {
       //8.1 Electronics
        [Test]
        public void Test1()
        {
            int waitingTime = 200;

            //8.1 Electronics
            var Electronics = webDriver.FindElement(By.XPath("./html/body/header/div/nav/div/div[1]/ul/li[2]/a"));

            //operation
            Electronics.Click();

            Thread.Sleep(waitingTime);


        }
        
        ////8.2 Stationary & Others
        [Test]
        public void Test2()
        {
            int waitingTime = 200;
            ////8.2 Stationary & Others

            var Stationary = webDriver.FindElement(By.XPath("./html/body/header/div/nav/div/div[1]/ul/li[3]/a"));

            //operation
            Stationary.Click();

            Thread.Sleep(waitingTime);
          
        }

        //8.3 Giftfinder
        [Test]
        public void Test3()
        {
            int waitingTime = 200;

            //8.3 Giftfinder
            var Giftfinder = webDriver.FindElement(By.XPath("./html/body/header/div/nav/div/div[1]/ul/li[4]/a"));

            //operation
            Giftfinder.Click();

            Thread.Sleep(waitingTime);


        }

        //8.4 Corporate
        [Test]
        public void Test4()
        {
            int waitingTime = 200;

            //8.4 Corporate
            var CorporateOrder = webDriver.FindElement(By.XPath("./html/body/header/div[6]/div/div/div/ul/li[5]/a"));

            //operation
            CorporateOrder.Click();

            Thread.Sleep(waitingTime);


        }
        
        //8.5 Offer
        [Test]
        public void Test5()
        {
            int waitingTime = 200;

            //8.5 Offer
            var Offer = webDriver.FindElement(By.XPath("./html/body/header/div[6]/div/div/div/ul/li[6]/a"));

            //operation
            Offer.Click();

            Thread.Sleep(waitingTime);


        }
        
        
        //8.6 Blog
        [Test]
        public void Test6()
        {
            int waitingTime = 200;

            //8.6 Blog
            var Blog = webDriver.FindElement(By.XPath("./html/body/header/div/nav/div/div/ul/li[7]/a"));

            //operation
            Blog.Click();

            Thread.Sleep(waitingTime);

        }


    }
}
