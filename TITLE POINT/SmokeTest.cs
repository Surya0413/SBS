using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Core;
using Action;
using System.Threading;

namespace TITLE_POINT
{
    [TestFixture]
    public class SmokeTest
    {
         [SetUp]
        public void Initialize()
        {

            BroserHandler.InitBrowser();
            BroserHandler.LoadApplication();

        }

       // [Test]
        public void Smoke_Namsearch()
        {
            LoginAction login = new LoginAction();
            login.Login();
            Thread.Sleep(2000);

            Menu menu = new Menu();
            menu.ClickMenu("Name");
            Thread.Sleep(6000);

            SwitchFrames.Switch_Default();
            SwitchFrames.Switch_MainBody();
            NameSearch name = new NameSearch();
            name.Name_Search();

            SwitchFrames.Switch_Default();
            SwitchFrames.Switch_RecentActivity();
            RecentActivity recentActivity = new RecentActivity();
            recentActivity.RA_Link();

        }    

    //[Test]
    public void Smoke_PropertySearch()
    {
        LoginAction login = new LoginAction();
        login.Login();
        Thread.Sleep(2000);

        Menu menu = new Menu();
        menu.ClickMenu("Property");
        Thread.Sleep(3000);

        SwitchFrames.Switch_Default();
        SwitchFrames.Switch_MainBody();
        propertySearch property = new propertySearch();
        property.property_Search();

    }
        
    //[Test]
    public void smoke_Tax()
    {
        LoginAction login = new LoginAction();
        login.Login();
        Thread.Sleep(3000);

        Menu menu = new Menu();
        menu.ClickMenu("Tax");
        Thread.Sleep(3000);

        SwitchFrames.Switch_Default();
        SwitchFrames.Switch_MainBody();
        TaxAction tax = new TaxAction();
        tax.Tax_search();
    }

   // [Test]
    public void smoke_Image()
    {
        LoginAction login = new LoginAction();
        login.Login();
        Thread.Sleep(3000);

        Menu menu = new Menu();
        menu.ClickMenu("Image");
        Thread.Sleep(3000);
        SwitchFrames.Switch_Default();
        SwitchFrames.Switch_MainBody();
        Image Img = new Image();
        Img.ImageSearch();

    }
        [Test]
        public void smoke_assert()
        {
            LoginAction login = new LoginAction();
            login.Login();
            Thread.Sleep(3000);

            Menu menu = new Menu();
            menu.ClickMenu("Name");
            Thread.Sleep(3000);
            SwitchFrames.Switch_Default();
            SwitchFrames.Switch_MainBody();
            NameSearch name = new NameSearch();
            name.Name_Search();
        }


        
  }
    
}
