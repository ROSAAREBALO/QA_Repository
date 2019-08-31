using OpenQA.Selenium;
using PageObjectLibrary.PageObject.AutomationPractice.SingIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObject.AutomationPractice.SingInButton.ProductMenu
{
   public class ProductMenuPage
    {
        IWebDriver webDriver;

        public ProductMenuPage(IWebDriver webDriver) {
            this.webDriver =webDriver;
        }


        public void PageAcoount() {
            IWebElement account = webDriver.FindElement(By.Id("my-account"));
            account.Click();
        }
    

        public void Women()
        {
            IWebElement women = webDriver.FindElement(By.XPath("//a[@title='Women']"));
            women.Click();
        }

       


        public void Dress()
        {
            IWebElement dress = webDriver.FindElement(By.XPath("//a[@title='Dresses']"));
            dress.Click();
        }

        public void TSthirt()
        {
            IWebElement tShirt = webDriver.FindElement(By.XPath("//a[@title='T-shirts']"));
            tShirt.Click();
        }

        public void CasualDress() {
            IWebElement selectCasualActual = webDriver.FindElement(By.XPath("//img[@title='Printed Dress']"));
            selectCasualActual.Click();
        }

        public void SelectWomen() {
          /*  PageAcoount();*/
            Women();
            CasualDress();
        }
/*
        public void selectProductMenu()
        {
            Women();
            IWebElement selectCasual = webDriver.FindElement(By.XPath("//a[@title='Casual Dresses']"));
            selectCasual.Click();
            IWebElement selectCasualActual = webDriver.FindElement(By.XPath("//img[@title='Printed Dress']"));
            selectCasualActual.Click();
            IWebElement selectAddCarButton = webDriver.FindElement(By.XPath("//a[@title='Add to cart']"));
            selectAddCarButton.Click();

            IWebElement selectProcedCheck = webDriver.FindElement(By.XPath("//i[@class='icon-chevron-right right']"));
            selectProcedCheck.Click();

            IWebElement selectProcedCheck2= webDriver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));
            selectProcedCheck2.Click();
        }
        */
     


    
}


}
