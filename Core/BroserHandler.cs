using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Core
{
    public class BroserHandler
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static void LoadApplication(string url ="https://qa2.titlepoint.biz")
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();

          //  IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
          //  IWebElement element = driver.FindElement(By.XPath("//span[@id='moreInfoContainer']/a"));
          //  executor.ExecuteScript("arguments[0].click();", element);
            Thread.Sleep(1000);
         //   IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
         //   IWebElement element1 = driver.FindElement(By.Id("overridelink"));
         //   executor1.ExecuteScript("arguments[0].click();", element1);
            Thread.Sleep(1500);
        }

        private static object syncRoot = new Object();
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    //string s = "";
                    try
                    {
                        throw new Exception();
                    }
                    catch { }
                }
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser()
        {
            if (driver == null)
            {
                lock (syncRoot)
                {
                    if (driver == null)
                    {
                        driver = new ChromeDriver(@"C:\Users\91834\source\repos\TITLE POINT\packages\Selenium.WebDriver.ChromeDriver.98.0.4758.10200\driver\win32");
                        Drivers.Add("Chrome", Driver);
                        //https://chromedriver.storage.googleapis.com/index.html?path=96.0.4664.35/
                    }
                }
            }
        }

        public static void LoadApplication_WebServer(string url = "https://www.titlepoint.com")
        {

            //Driver.Navigate().GoToUrl(DataHandler.Instance.GetParam("URL"));
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//span[@id='moreInfoContainer']/a"));
            executor.ExecuteScript("arguments[0].click();", element);
            Thread.Sleep(1000);
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            IWebElement element1 = driver.FindElement(By.Id("overridelink"));
            executor1.ExecuteScript("arguments[0].click();", element1);
            Thread.Sleep(1500);
            //IAlert simpleAlert = driver.SwitchTo().Alert();
            // simpleAlert.Accept();

        }

        //public static void CloseAllDrivers()
        //{
        //    foreach (var key in Drivers.Keys)
        //    {
        //        Drivers[key].Close();
        //        Drivers[key].Quit();
        //    }
        //}

        //public static void ClearDriver()
        //{
        //    Thread.Sleep(1500);
        //    driver = null;
        //}


    }
}
