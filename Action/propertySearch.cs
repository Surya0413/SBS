using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Core;
using PageObject;
using OpenQA.Selenium.Support.UI;

namespace Action
{
    public class propertySearch
    {
        IWebDriver driver;
        propertySearchPO propsearch = null;

        public void property_Search()
        {
            driver = BroserHandler.Driver;
            propsearch = new PageObject.propertySearchPO();
           String orderno= DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString();

            propsearch.orderNo.SendKeys(orderno);
            SelectElement dropdownprop = new SelectElement(propsearch.state);
            dropdownprop.SelectByText("California");
            dropdownprop = new SelectElement(propsearch.county);
            dropdownprop.SelectByText("Los Angeles");
            propsearch.book.SendKeys("01");
            propsearch.page.SendKeys("20");
            propsearch.fromDate.SendKeys("05/15/20");
            propsearch.throughDate.SendKeys("09/20/21");
            propsearch.beginSearch.Click();

        }



    }
}
