using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RokomariTestProject.Assignment_01.pages.Home_Page;
using System.Threading;

namespace RokomariTestProject.Assignment_01.tests.LogIn
{
    public class SignUpTest : BasePage
    {
       
        [Test]
        public void SignUp()
        {
            int waitingTime = 200;

            //Identify Sign Up
            IWebElement lnkSignIn = webDriver.FindElement(By.LinkText("Sign in"));
            
            //operation
            lnkSignIn.Click();

            Thread.Sleep(waitingTime);

            IWebElement lnkSignUp = webDriver.FindElement(By.ClassName("js--registration-form-btn"));

            //operation
            lnkSignUp.Click();

            Thread.Sleep(waitingTime);


            // Full Name
            var textFullName = webDriver.FindElement(By.Id("nm"));

            textFullName.SendKeys("Akteruzzaman");

            // Email
            var textEmail = webDriver.FindElement(By.Id("js-email"));

            textEmail.SendKeys("nurchoton2@gmail.com");

            // Phone
            var textPhone = webDriver.FindElement(By.Id("js-phone"));

            textPhone.SendKeys("01639484292");

            //Password

            var textPassword = webDriver.FindElement(By.Id("pwd"));

            textPassword.SendKeys("lolme1011");

            Thread.Sleep(waitingTime);

            //SignIn
            var CreateAccount = webDriver.FindElement(By.XPath(".//*[@id=\"accountForm\"]/button"));

            //operation
            CreateAccount.SendKeys(Keys.Enter);

            Thread.Sleep(waitingTime);

        }





    }
}