using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Core;


namespace PageObject
{
    public class ComboPO
    {
        IWebDriver driver = BroserHandler.Driver;

        public IWebElement orderNO => driver.FindElement(By.Id("orderNumber"));
        public IWebElement State => driver.FindElement(By.XPath("//select[contains(@data-bind,'States')]"));

        public IWebElement County => driver.FindElement(By.XPath("//select[contains(@data-bind,'Counties')]"));

        public IWebElement Map => driver.FindElement(By.Id("//select[@id='PropertyParamsViewTitlePoint_0_FormatValue']"));


    }
}
