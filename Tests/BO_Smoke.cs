﻿using System;
using Framework;
using Framework.Pages;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
    {
    [TestClass]
    public class BO_Smoke : TestBase
        {

        [TestMethod, Priority(1)]
        // This method will login to BO->Navigate to Company profile page by Searching Company using CIF->Click Add User -> User will be added with details
        public void AddCompUser()
            {
            try
                {

                AllPages.BO_Login.Goto();

                Assert.IsTrue(AllPages.BO_Login.IsAt());
                Thread.Sleep(20000);
                AllPages.BO_Login.Login();
                Thread.Sleep(20000);
                AllPages.RsaPage.RsaQues();
                AllPages.RsaPage.RsaQues1();
                Thread.Sleep(20000);
                AllPages.HomePage.CompSearch();

                Thread.Sleep(10000);

                AllPages.HomePage.AddCompUser();

                Browser.Close();
                }
            catch (Exception ex)
                {
                Console.WriteLine(ex.StackTrace);
                Assert.AreEqual(AllPages.BoUser.verAssert(), "Add Use"); // Not Visible Works
                Browser.Close();

                }
            }

        //asd
        [TestMethod, Priority(2)]
        // This Method will click on User menu in BO application -> And click on User List option

        public void FIUsersPage()
            {
            try
                {
                AllPages.BO_Login.Goto();
                Assert.IsTrue(AllPages.BO_Login.IsAt());
                Thread.Sleep(10000);

                AllPages.BO_Login.Login();
                Thread.Sleep(10000);

                AllPages.RsaPage.RsaQues();
                AllPages.RsaPage.RsaQues1();
                Thread.Sleep(10000);

                AllPages.BoUser.FIUserList();

                Browser.Close();
                }

            catch (Exception ex)
                {
                Console.WriteLine(ex.StackTrace);
                Assert.AreEqual(AllPages.BoUser.verAssert(), "Add Use"); // Not Visible Works
                Browser.Close();

                }

            }

        [TestMethod, Priority(2)]
        // This Method will click on User menu in BO application -> And click on User Roles option
        public void FIUsersRolesPage()
            {
            try
                {
                AllPages.BO_Login.Goto();
                Assert.IsTrue(AllPages.BO_Login.IsAt());
                AllPages.BO_Login.Login();
                Thread.Sleep(10000);

                AllPages.RsaPage.RsaQues();
                AllPages.RsaPage.RsaQues1();
                Thread.Sleep(10000);

                AllPages.BoUser.FIUserRoles();
                //test finish
                Browser.Close();
                }

            catch (Exception ex)
                {
                Console.WriteLine(ex.StackTrace);
                Assert.AreEqual(AllPages.BoUser.verAssert(), "Add Use"); // Not Visible Works
                Browser.Close();

                }

            }

        }
    }
