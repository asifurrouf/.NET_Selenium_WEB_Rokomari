using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using RokomariTestProject.Assignment_01.tests.LogIn;
using System.Threading;

namespace RokomariTestProject
{
    public class ProfileTests : SignInTest
    {
       //4.1 my account
        [Test]
        public void Test1()
        {
            int waitingTime = 200;

            //4.1 my account
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyAccount = webDriver.FindElement(By.LinkText("My Account"));

            //operation
            MyAccount.Click();

            Thread.Sleep(waitingTime);


        }

        ////4.2 My Order
        [Test]
        public void Test2()
        {
            int waitingTime = 200;
            ////4.2 My Order
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyOrder = webDriver.FindElement(By.LinkText("My Orders"));

            //operation
            MyOrder.Click();

            Thread.Sleep(waitingTime);
          
        }
        
        ////4.3 My List
        [Test]
        public void Test3()
        {
            int waitingTime = 200;
            ////4.3 My List
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyList = webDriver.FindElement(By.LinkText("My List"));

            //operation
            MyList.Click();

            Thread.Sleep(waitingTime);

        }

        ////4.4 My Wishlist
        [Test]
        public void Test4()
        {
            int waitingTime = 200;
            ////4.4 My Wishlist
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyWishlist = webDriver.FindElement(By.LinkText("My Wishlist"));

            //operation
            MyWishlist.Click();

            Thread.Sleep(waitingTime);

        }

        ////4.5 My Rating Reviews
        [Test]
        public void Test5()
        {
            int waitingTime = 200;
            ////4.5 My Rating Reviews
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyRatingReviews = webDriver.FindElement(By.LinkText("My Rating Reviews"));

            //operation
            MyRatingReviews.Click();

            Thread.Sleep(waitingTime);

        }

        ////4.6 My Points
        [Test]
        public void Test6()
        {
            int waitingTime = 200;
            ////4.6 My Points
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var MyPoints = webDriver.FindElement(By.LinkText("My Points"));

            //operation
            MyPoints.Click();

            Thread.Sleep(waitingTime);

        }
        
        ////4.7 Sign Out
        [Test]
        public void Test7()
        {
            int waitingTime = 200;
            ////4.7 Sign Out
            var linkProfile = webDriver.FindElement(By.Id("dropdownMenu2"));
            linkProfile.Click();

            var SignOut = webDriver.FindElement(By.LinkText("Sign Out"));

            //operation
            SignOut.Click();

            Thread.Sleep(waitingTime);

        }


    }
}
