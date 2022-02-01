using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using System.Threading;

namespace RokomariTestProject.Assignment_01.tests.LogIn
{

    
    public class FaceBookTests : BasePage
    {
        int waitingTime = 200;

        [Test]

        public void FBTest()
        {
            //Identify SignIn
            IWebElement lnkSignIn = webDriver.FindElement(By.LinkText("Sign in"));

            //operation
            lnkSignIn.Click();

            Thread.Sleep(waitingTime);

            //SignIn by facebook
            var input_facebook = webDriver.FindElement(By.ClassName("btn-social-facebook"));

            //operation
            input_facebook.SendKeys(Keys.Enter);

            Thread.Sleep(waitingTime);
        }

       

    }

    public class GoogleTests : BasePage
    {
        int waitingTime = 200;

        [Test]

        public void GoogleTest()
        {
            //Identify SignIn
            IWebElement lnkSignIn = webDriver.FindElement(By.ClassName("logged-out-user-menu-btn"));

            //operation
            lnkSignIn.Click(); 

            Thread.Sleep(waitingTime);

            //SignIn by facebook
            var input_Google = webDriver.FindElement(By.ClassName("btn-social-google"));

            //operation
            input_Google.SendKeys(Keys.Enter);

            Thread.Sleep(waitingTime);

        }


    }
}