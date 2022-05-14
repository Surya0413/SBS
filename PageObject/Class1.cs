using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

using Core;


namespace PageObject
{
   
    public class Login
    {
        IWebDriver driver = BroserHandler.Driver;

        public IWebElement UserName => driver.FindElement(By.Id("tbxUserName"));

        public IWebElement Password => driver.FindElement(By.Id("tbxPassword"));

        public IWebElement btnLogin => driver.FindElement(By.Id("btnSubmit"));

        //[FindsBy(How = How.Id, Using = "tbxUserName")]
        //public IWebElement UserName { get; set; }

        //[FindsBy(How=How.Id, Using = "tbxPassword")]
        //public IWebElement Password { get; set; }

        //[FindsBy(How=How.Id,Using = "btnSubmit")]
        //public IWebElement btnLogin { get; set; }
    }
}
