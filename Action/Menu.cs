using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Core;
using System.Threading;

namespace Action
{
    public class Menu
    {
        IWebDriver driver = null;


        public void ClickMenu(String Menu)
        {
            driver = BroserHandler.Driver;
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            switch(Menu)
            {
                case "Name":
                    {
                        Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='menu']/li[8]/a/span")).Click();
                        break;
                    }
                case "Property":
                    {
                        Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='menu']/li[7]/a/span")).Click();
                        break;
                    }
                case "Image":
                    {
                        Thread.Sleep(2000);
                        driver.FindElement(By.XPath("//*[@id='menu']/li[11]/a/span")).Click();
                        break;
                    }
            }

           

        }
    }
}
