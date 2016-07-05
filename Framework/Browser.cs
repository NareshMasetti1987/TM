using System.Security.Policy;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;
using System;
using System.Linq;
using log4net;
using Framework.ComponentHelper;


namespace Framework
{
    public static class Browser
    {

        // Logs
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(Browser));

        //private static IWebDriver _webDriver = new FirefoxDriver();

        private static IWebDriver _webDriver = new ChromeDriver();
        
        
          //  ChromeOptions options = new ChromeOptions();
          //  options.AddArguments("disable-extensions");
        
        
        private static string _BoUrl = "https://treasury-backoffice-e.qa.netteller.com";
        private static string _ChUrl =  "https://treasury-channel-e.qa.netteller.com:8080/#/login";

        public static ISearchContext Driver
        {
            get { return _webDriver; } 
        }

        public static string Title { get { return _webDriver.Title; } }

        public static void Goto(string url)
        {
        Logger.Info("Will open url");
            _webDriver.Navigate().GoToUrl(_BoUrl + url);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(90));
            _webDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(50));
            _webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(40));

            Logger.Info("Opened url");

            
        }
        public static void Initialize()
        {
            Goto("");
        }

        public static void Close()
        {
            _webDriver.Close();
        }
    }
}