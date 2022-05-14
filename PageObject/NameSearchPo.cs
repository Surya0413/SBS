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
    public class NameSearchPo
    {
        IWebDriver driver = BroserHandler.Driver;

        public IWebElement orderNumber => driver.FindElement(By.Id("orderNumber"));

        public IWebElement state => driver.FindElement(By.XPath("//select[contains(@data-bind,'states')]"));

        public IWebElement county => driver.FindElement(By.XPath("//select[contains(@data-bind,'Counties')]"));

        public IWebElement names => driver.FindElement(By.XPath("//input[@id='NameParamsView_0_Name']"));

        public IWebElement fromDate => driver.FindElement(By.XPath("//input[@id='txtFromDate']"));
        public IWebElement throughDate => driver.FindElement(By.XPath("//input[@id='txtThruDate']"));
        public IWebElement beginSearch => driver.FindElement(By.XPath("//button[text()='Begin Search']"));
        public IWebElement AddtoRequestImg => driver.FindElement(By.XPath("//button[text()='Add to Requests']"));
        public IWebElement ViewImg => driver.FindElement(By.XPath("//button[text()='View Image']"));
        
    }
}
