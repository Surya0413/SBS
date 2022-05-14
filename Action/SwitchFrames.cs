using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core;
using OpenQA.Selenium;

namespace Action
{
   public class SwitchFrames
    {

        public static void Switch_RecentActivity()
        {
            //Recent Activity
            BroserHandler.Driver.SwitchTo().DefaultContent();
            BroserHandler.Driver.SwitchTo().Frame(BroserHandler.Driver.FindElement(By.Id("ifrActivity")));
        }
        public static void Switch_Default()
        {
            Thread.Sleep(1000);
            BroserHandler.Driver.SwitchTo().DefaultContent();
        }
        public static void Switch_SearchParameters()
        {
            Thread.Sleep(1200);
            BroserHandler.Driver.SwitchTo().DefaultContent();
            BroserHandler.Driver.SwitchTo().Frame(BroserHandler.Driver.FindElement(By.Id("ifrSearchParams")));
        }
        public static void Switch_PropertyHistory()
        {
            Switch_MainBody();
            //BrowserHandler.Driver.SwitchTo().DefaultContent();
            BroserHandler.Driver.SwitchTo().Frame(BroserHandler.Driver.FindElement(By.Id("iframePropertyHistory")));
        }
        public static void Switch_MainBody()
        {
            //Thread.Sleep(1500);
            try
            {
                BroserHandler.Driver.SwitchTo().DefaultContent();
                BroserHandler.Driver.SwitchTo().Frame(BroserHandler.Driver.FindElement(By.Id("ifrMainBody")));
            }
            catch
            {
                BroserHandler.Driver.SwitchTo().DefaultContent();
                BroserHandler.Driver.SwitchTo().Frame(BroserHandler.Driver.FindElement(By.Id("ifrMainBody")));
            }

        }


    }
}
