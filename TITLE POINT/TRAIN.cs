using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;
using NUnit;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace TITLE_POINT
{
    [TestFixture]
    class TRAIN
    { 
      [Test]
      public void TRAIN_LOGIN()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.irctc.co.in");
            //Thread.Sleep(15000);

            ////driver.FindElement(By.XPath("//button[contains(@class,'btn-primary')]")).Click();
            //IAlert simplealert = driver.SwitchTo().Alert();
            //simplealert.Accept();

            //   ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//button[contains(@class,'btn-primary')]")));


            //Thread.Sleep(3000);

            //driver.FindElement(By.XPath("//input[contains(@class,'ng-tns-c58-8')]")).SendKeys("WARANGAL");
            //    driver.FindElement(By.XPath("//input[contains(@class,'ng-tns-c58-9')]")).SendKeys("HYDERABAD");
            ////driver.FindElement(By.XPath("//input[contains(@class,'ng-tns-c59-10')]")).SendKeys("19/01/2022");
            //Thread.Sleep(3000);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//button[text()='Search']")));
            ////driver.FindElement(By.XPath("//button[text()='Search']")).Click();
            //Thread.Sleep(3000);

            //var vv =driver.WindowHandles;
            //driver.SwitchTo().Window(vv[0]);


            //WebDriverWait drivers = new WebDriverWait(driver,TimeSpan.FromMinutes(1));
            //drivers.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //Func<IWebDriver, bool> funDr = delegate( IWebDriver dr) 
            //{


            //    return false;
            //};

            //Func<IWebDriver, bool> ssdr = (IWebDriver dr) => {

            //    return true;
            //};


            //drivers.Until(ssdr);

            //DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(driver.FindElement(By.XPath("//a")));
            //wait.Timeout = TimeSpan.FromMinutes(2);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //Func<IWebElement,IWebElement> eleMents = (IWebElement ssEle) =>
            //{
            //    IWebElement eel = driver.FindElement(By.XPath("//a"));
            //    return eel;

            //};

            //wait.Until(eleMents);




        }

        public bool show(IWebDriver driver)
        {

            return false;
        }
    }

    abstract class a
    {
        public abstract void shos();
        public void showme()
        {
            Console.WriteLine("s");
        }
    }

    class bb :a
    {
        public override void shos()
        {
            Console.WriteLine("hi");
        }

        public void Got()
        {
            Console.WriteLine("his");
        }
    }

    class bshow
    {
        public void ssgo()
        {
            a asdf = new bb();
            asdf.shos();
            asdf.showme();
            
        }
         
    }
}

