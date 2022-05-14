using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit;
using NUnit.Framework;


namespace Action
{
    [TestFixture]
    public class RecentActivity
    {
        IWebDriver driver;
        
        public void RA_Link()
        {
            driver.FindElement(By.XPath("//span[contains(@id,'raTb') and contains(@id,'NodeText') and (text()='Order 1212082404')]")).Click();

        }
    }
}
