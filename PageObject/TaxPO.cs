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
    public class TaxPO
    {
        IWebDriver driver = BroserHandler.Driver;
        public IWebElement orderNo => driver.FindElement(By.Id("orderNumber"));

        public IWebElement AddtoExisting => driver.FindElement(By.XPath("//input[@type='checkbox' and contains(@data-bind,'AddToExistingOrder')]"));
        public IWebElement State => driver.FindElement(By.XPath("//select[contains(@data-bind,'States, currentCountyObject')]"));
        public IWebElement County => driver.FindElement(By.XPath("//select[contains(@data-bind,'StateName.Counties')]"));
        //public IWebElement TaxIdentification => driver.FindElement(By.XPath("//label[text()='Tax Identification Number']/input"));
       // public IWebElement AddressName => driver.FindElement(By.XPath("//span[@id='searchByAddressOrNameLabel']/preceding-sibling::input"));
       // public IWebElement LegalSescription => driver.FindElement(By.XPath("//span[@id='searchByAddressOrNameLabel']/preceding-sibling::input"));

        public IWebElement BeginSearch => driver.FindElement(By.XPath("//button[text()='Begin Search']"));
    }
}
