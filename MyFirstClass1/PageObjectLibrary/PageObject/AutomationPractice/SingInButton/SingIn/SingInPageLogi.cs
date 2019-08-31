using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObject.AutomationPractice.SingIn
{
    public class SingInPageLogi
    {
        IWebDriver webDriver;

        public SingInPageLogi(IWebDriver webDriver) {
            this.webDriver = webDriver;
        }

        public void SetLogiEmail(string email) {
            IWebElement loginEmail = webDriver.FindElement(By.Name("email"));
            loginEmail.SendKeys(email);

        }

        public void SetLoginPassword(string password) {
            IWebElement loginPassword = webDriver.FindElement(By.Id("passwd"));
            loginPassword.SendKeys(password);

        }

        public void ClickSingInLogin() {
            IWebElement click = webDriver.FindElement(By.Id("SubmitLogin"));
            click.Click();
            InputLoginPageUser();
            


        }
      
        public void FillLoginForm(string email, string password) {
            SetLogiEmail(email);
            SetLoginPassword(password);
            ClickSingInLogin();
          

        }

       public void InputLoginPageUser()
        {
            IWebElement inputLoginPageUser = webDriver.FindElement(By.XPath("//a[@class='account']"));
            inputLoginPageUser.Click();


        }



        


    }
}
