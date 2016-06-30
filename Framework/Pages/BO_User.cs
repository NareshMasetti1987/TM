using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
    {
    public class BO_User
        {

        [FindsBy(How = How.XPath, Using = ".//a[contains(.,'User   ')]")]
        public IWebElement UserMenu;

        [FindsBy(How = How.XPath, Using = ".//a[contains(.,'User List')]")]
        public IWebElement UserList;

        [FindsBy(How = How.XPath, Using = ".//a[contains(.,'User Roles')]")]
        public IWebElement UserRoles;

        [FindsBy(How = How.XPath, Using = ".//button[contains(.,'Add User')]")]
        public IWebElement AddFiUser;

        public  string verAssert()
            {

            string addUs = AddFiUser.Text;
            return addUs;

            }
    
        
        public void FIUserList()
            {

            UserMenu.Click();
            UserList.Click();
           
            }

        public void FIUserRoles()
            {

            
            UserMenu.Click();
            UserRoles.Click();
            }
        }
    }
