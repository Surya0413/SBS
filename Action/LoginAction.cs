using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Core;
using PageObject;


namespace Action
{
   public class LoginAction
    {
        IWebDriver driver;
        Login loginP = null;

        public void Login()
        {
            driver = BroserHandler.Driver;
            loginP = new PageObject.Login();
           

            loginP.UserName.SendKeys("tptest902");
            loginP.Password.SendKeys("Title$4321");
            loginP.btnLogin.Click();
        }

    }
}
