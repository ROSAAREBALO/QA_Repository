using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary.PageObject.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObject.AutomationPractice.SingIn;
using PageObjectLibrary.Steps.AutomationPractice.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass1
{
    [TestClass]
    public class Class1
    {
        IWebDriver webDriver;
        NavigationSteps navigationSteps;


        /*
         * public Class1(){
         *webDriver = new ChromeDriver(@"C:\selenumWebDriver");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            navigationSteps = new NavigationSteps(webDriver);
        }
         */



        [TestMethod]
        public void ContactUsFormIsSentCorrectly()
        {
            ContactUsPage contactUsPage = navigationSteps.NavigateContactUs();

            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service", "daniel.terceros@gmail.com", "1234", @"D:\prueba\FilePlano.txt", "my message");
            string actualMessage = contactUsPage.GetConfirmationMessage();
            string expectedMessage = "Your message has been successfully sent to our team.";
            Assert.AreEqual(expectedMessage, actualMessage);

          

        }
        [TestMethod]
        public void SingInFormCorrectly()
        {

            SingInPageLogi singIngPagiLogi = navigationSteps.NavigateSingIn();
            singIngPagiLogi.FillLoginForm("ro18uskali@gmail.com","12345rous");
           

        }

        /*
        [TestMethod]
        public void ContactUsFormIsNotSendWithInvalidData() {
            ContactUsPage contactUsPage = navigationSteps.NavigateContactUs();

            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText, "Customer service",
                "invalid email", "1234", @"D:\prueba\FilePlano.txt", "my message no arrived espect");
            string actualMessage = contactUsPage.GetErrorLabel();
            string expectedMessage = "invalid email address";
            Assert.AreEqual(expectedMessage, actualMessage);

        }*/

        [TestInitialize]
        public void TestSetup() {


            webDriver = new ChromeDriver(@"C:\selenumWebDriver");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            navigationSteps = new NavigationSteps(webDriver);
        }

       /* [TestCleanup]
        public void TestTearDown() {
            webDriver.Close();
            webDriver.Quit();
        }

       */

    }
}
