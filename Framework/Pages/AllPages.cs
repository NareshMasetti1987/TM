using System.Dynamic;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
    {
    public static class AllPages
        {
        private static T GetPage<T>() where T : new()
            {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
            }

        public static BO_LoginPage BO_Login
            {
            get { return GetPage<BO_LoginPage>(); }
            }

        public static BO_SecurityQuestions RsaPage
            {
            get { return GetPage<BO_SecurityQuestions>(); }

            }

        public static BO_HomePage HomePage
            {

            get { return GetPage<BO_HomePage>(); }
            }

        public static BO_User BoUser
            {

            get { return GetPage<BO_User>(); }
            }
        }
    }