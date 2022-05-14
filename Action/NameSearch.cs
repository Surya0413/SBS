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
    public class NameSearch
    {
        IWebDriver driver;
        NameSearchPo nameSearchp = null;

        public void Name_Search()
        {
            Random rn = new Random();
            driver = BroserHandler.Driver;
            nameSearchp = new PageObject.NameSearchPo();
            

            nameSearchp.orderNumber.SendKeys("samSA"+ rn.Next(99,9999));
            SelectElement dropDown = new SelectElement(nameSearchp.state);
            dropDown.SelectByText("California");
            dropDown = new SelectElement(nameSearchp.county);
            dropDown.SelectByText("Los Angeles");

            nameSearchp.names.SendKeys("samSAE");
            nameSearchp.fromDate.SendKeys("05/11/1984");
            nameSearchp.throughDate.SendKeys("12/12/2020");
            nameSearchp.beginSearch.Click();


        }
    }
}
