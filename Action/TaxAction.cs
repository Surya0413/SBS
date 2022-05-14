using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Core;
using NUnit.Framework;
using PageObject;
using OpenQA.Selenium.Support.UI;


namespace Action
{
   public class TaxAction
    {
        IWebDriver driver;
        TaxPO tax = null;

        public void Tax_search()
        {
            Random rn = new Random();
            driver = BroserHandler.Driver;
            tax = new PageObject.TaxPO();

            tax.orderNo.SendKeys("abc+rn.next(99,9999)");
            tax.AddtoExisting.SendKeys("3");
            tax.State.SendKeys("Brown");
            tax.County.SendKeys("Los Angels");
           // tax.TaxIdentification.SendKeys("1234");
            //tax.AddressName.SendKeys("Brownsusan");
            //tax.LegalSescription.SendKeys("123brown");
            tax.BeginSearch.Click();
           
           

        }
    }
}
