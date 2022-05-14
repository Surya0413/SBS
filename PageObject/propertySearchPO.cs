using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


namespace PageObject
{
   public  class propertySearchPO
    {
        IWebDriver driver = BroserHandler.Driver;

        public IWebElement orderNo => driver.FindElement(By.Id("orderNumber"));
        public IWebElement state => driver.FindElement(By.XPath("//select[contains(@data-bind,'States')]"));
        public IWebElement county => driver.FindElement(By.XPath("//select[contains(@data-bind,'Counties')]"));
        public IWebElement maps => driver.FindElement(By.Id("//select[@id='PropertyParamsViewTitlePoint_0_FormatValue']"));
        public IWebElement book => driver.FindElement(By.XPath("//div[@class='formItem' and contains(@data-bind,'visible')]/child::label/span[text()='Book']/parent::*/..//input"));
        public IWebElement page => driver.FindElement(By.XPath("//div[@class='formItem' and contains(@data-bind,'visible')]/child::label/span[text()='Page']/parent::*/..//input"));
        public IWebElement fromDate => driver.FindElement(By.Id("txtFromDate"));
        public IWebElement throughDate => driver.FindElement(By.Id("txtThruDate"));
        public IWebElement beginSearch =>driver.FindElement(By.XPath("//button[text()='Begin Search']"));
    }
}
