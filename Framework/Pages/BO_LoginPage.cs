using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace Framework.Pages
    {
    public class BO_LoginPage
        {
        [FindsBy(How = How.XPath, Using = ".//*[@id='inputFiId']")]
        public IWebElement FIID;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputID']")]
        public IWebElement LoginID;

        [FindsBy(How = How.XPath, Using = ".//*[@id='inputPassword']")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-view']/div/div[2]/button")]
        public IWebElement LoginButton;

        public void Goto()
            {
            Browser.Goto("/#/login");
            }

        public bool IsAt()
            {
            return Browser.Title.Contains("Jack Henry BackOffice");

            }

      

        public void Login()
            {
            FIID.SendKeys("110618");
            LoginID.SendKeys("JhaAdmin");
            Password.SendKeys("password1");
            LoginButton.Click();
            }
        }
    }