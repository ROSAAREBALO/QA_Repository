using OpenQA.Selenium;
using PageObjectLibrary.PageObject.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObject.AutomationPractice.Menu;
using PageObjectLibrary.PageObject.AutomationPractice.SingIn;
using PageObjectLibrary.PageObject.AutomationPractice.SingInButton.ProductMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.Steps.AutomationPractice.Navigation
{
   public   class NavigationSteps
    {
        IWebDriver webDriver;

        public NavigationSteps(IWebDriver webDriver) {
            this.webDriver = webDriver;
        }

        public ContactUsPage NavigateContactUs() {
            MenuPage menuPagine = new MenuPage(webDriver);
            ContactUsPage contactUsPage = menuPagine.ClickContactUs();
            return contactUsPage;

        }

        public SingInPageLogi NavigateSingIn() {
            MenuPage menuPage = new MenuPage(webDriver);
            SingInPageLogi pageLogin = menuPage.ClickSingIn();

            return pageLogin;
        }

        public ProductMenuPage NavigatePageAccount()
        {
            MenuPage menuPage = new MenuPage(webDriver);
            ProductMenuPage pageAccount = menuPage.PageLoginAccount1();

            return pageAccount;
        }
        
    }
}
