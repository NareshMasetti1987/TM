using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Pages
    {
    public class BO_HomePage
        {
        string DATETIME = DateTime.Now.ToString("MMddhhmmss");
        string MAILID = "@jackhenry.com";

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_dropdown_00001']")]
        public IWebElement CompSearchType;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctrl_textbox_00001']")]
        public IWebElement CIFValue;

        [FindsBy(How = How.XPath, Using = ".//button[@type='submit']")]
        public IWebElement SearchComp;

        [FindsBy(How = How.XPath, Using = ".//*[@href='javascript:void(0)']")]
        public IWebElement SelectCompany;


        //Click on Add Company user button

        [FindsBy(How = How.XPath, Using = ".//button[@title='Add User']")]
        public IWebElement AddUserButton;

        //Enter User details

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_00001']")]
        public IWebElement UserName;

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_00002']")]
        public IWebElement LoginID;

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_00004']")]
        public IWebElement eMAIL;

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_000007']")]
        public IWebElement Ph1;

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_0000071']")]
        public IWebElement Ph2;

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctrl_textbox_0000072']")]
        public IWebElement Ph3;

        [FindsBy(How = How.XPath, Using = ".//*[@id='manageUserForm']/div[2]/div/div[1]/div/div[9]/div/button[2]")]
        public IWebElement SuperUser;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Save & Enroll')]")]
        public IWebElement SaveAndEnroll;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Confirm')]")]
        public IWebElement ConfirmAddUser;

        public void SearchType()
            {
            //create select element object 
            var selectElement = new SelectElement(CompSearchType);

            // select by text
            selectElement.SelectByText("CIF Number");
            }


        public void CompSearch()
            {
            SearchType();
            CIFValue.SendKeys("TAA0015");
            Thread.Sleep(10000);
            SearchComp.Click();
            SelectCompany.Click();
            Thread.Sleep(20000);
            AddUserButton.Click();

            }

        //Add Company User flow
        public void AddCompUser()
            {
            UserName.SendKeys("SMoke!" + DATETIME);
            LoginID.SendKeys("SMoke!" + DATETIME);
            eMAIL.SendKeys(DATETIME + MAILID);
            Ph1.SendKeys("111");
            Ph2.SendKeys("111");
            Ph3.SendKeys("1111");
            SuperUser.Click();
            SaveAndEnroll.Click();
            Thread.Sleep(10000);
            ConfirmAddUser.Click();
            }
        }
    }
