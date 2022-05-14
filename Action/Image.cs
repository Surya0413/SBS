using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using PageObject;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;

namespace Action
{
   public class Image
    {
        IWebDriver driver;
        ImagePO imgsearch = null;

        public void ImageSearch()
        {
            driver = BroserHandler.Driver;
            imgsearch = new ImagePO();
            Thread.Sleep(1000);
            imgsearch.OrderNoImg.SendKeys("123");
            Thread.Sleep(3000);

            SelectElement dropImg = new SelectElement(imgsearch.StateImg);
            dropImg.SelectByValue("Florida");
            Thread.Sleep(1000);

            SelectElement dropCounty = new SelectElement(imgsearch.CountyImg);
            dropCounty.SelectByText("Alachua");Thread.Sleep(3000);

            SelectElement dropFormat = new SelectElement(imgsearch.FullformatImg);
            dropFormat.SelectByText("Plat Maps");
            imgsearch.BookImg.SendKeys("1");Thread.Sleep(1000);
            imgsearch.PageImg.Click();
            imgsearch.PageImg.SendKeys("1");
            Thread.Sleep(1000);
            imgsearch.AddtoRequest.Click();
            Thread.Sleep(5000);
            //  imgsearch.Viewimg.Click();
            string val = "1-1 MAP PLAT ";
            List<IWebElement> eleList = driver.FindElements(By.XPath("/html/body/div[8]/div[2]/div[2]/table/tbody/tr/td[4]/a/label")).ToList();

            foreach (IWebElement el in eleList )
            {
                Assert.AreEqual(val, el.GetAttribute("innerText"));
            }

       //   string result=  driver.FindElement(By.XPath("//label[text()='"+val+"'] ")).Text;
           // Assert.AreEqual(val, result);
         //   Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[8]/div[2]/div[2]/table/tbody/tr/td[4]/a/label")).Displayed);




        }


    }
}
