using OpenQA.Selenium;
using PageObjectLibrary.PageObject.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObject.AutomationPractice.SingIn;
using PageObjectLibrary.PageObject.AutomationPractice.SingInButton.ProductMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObject.AutomationPractice.Menu
{
    public class MenuPage
    {
        IWebDriver webDriver;

        public MenuPage(IWebDriver webDriver) {
            this.webDriver = webDriver;
        }

        public ContactUsPage ClickContactUs(){
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();
            ContactUsPage contactUsPage = new ContactUsPage(webDriver);
            return contactUsPage;

        }

        public SingInPageLogi ClickSingIn() {
            IWebElement clickSing = webDriver.FindElement(By.XPath("//a[@class='login']"));
            clickSing.Click();            

            SingInPageLogi inputSingIn = new SingInPageLogi(webDriver);
           return inputSingIn;
        }

        public ProductMenuPage PageLoginAccount1(){
            IWebElement clickAccount = webDriver.FindElement(By.Id("my-account"));
            clickAccount.Click();
            ProductMenuPage pageAccount = new ProductMenuPage(webDriver);
            return pageAccount;
        }
        


    }
}
