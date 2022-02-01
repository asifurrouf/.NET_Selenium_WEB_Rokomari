using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using System.Threading;

namespace RokomariTestProject.Assignment_01.tests.LogIn
{
    public class SignInTest : BasePage
    {
        int waitingTime = 200;

        [Test]
        public void Test()
        {
            
            
            //Identify SignIn
            IWebElement lnkSignIn = webDriver.FindElement(By.LinkText("Sign in"));
            
            //operation
            lnkSignIn.Click();

            Thread.Sleep(waitingTime);

            //username
            var textUserName = webDriver.FindElement(By.Id("j_username"));
            
            textUserName.SendKeys("01888018837");

            //Password

            var textPassword = webDriver.FindElement(By.Id("j_password"));

            textPassword.SendKeys("lolme1011");

            Thread.Sleep(waitingTime);

            //SignIn
            var input_box = webDriver.FindElement(By.XPath(".//*[@id=\"loginForm\"]/button"));
            
            //operation
            input_box.SendKeys(Keys.Enter);

            Thread.Sleep(waitingTime);

        }

       


        
    }
}