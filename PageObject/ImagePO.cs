using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace PageObject
{
   public class ImagePO
    {
        IWebDriver driver = BroserHandler.Driver;

        public IWebElement OrderNoImg => driver.FindElement(By.Id("orderNumber"));
        public IWebElement StateImg => driver.FindElement(By.XPath("//select[contains(@data-bind,'states')]"));
        public IWebElement CountyImg => driver.FindElement(By.XPath("//select[contains(@data-bind,'Counties')]"));
        public IWebElement FormatImg => driver.FindElement(By.XPath("//select[contains(@data-bind,'selectedFormat')]"));
        public IWebElement FullformatImg => driver.FindElement(By.XPath("/html/body/div[7]/div[2]/table/tbody/tr[1]/td/div/div[1]/div/select"));
        public IWebElement BookImg => driver.FindElement(By.XPath("//input[@id='BOOK']"));
        public IWebElement PageImg => driver.FindElement(By.XPath("//input[@id='PAGE']"));
        public IWebElement AddtoRequest => driver.FindElement(By.XPath("//button[text()='Add to Requests']"));
        public IWebElement Viewimg => driver.FindElement(By.XPath("//button[text()='View Image']"));







    }
}
