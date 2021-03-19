using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace NUnitTestProject2
{
    public class TestBase
    {

        protected ApplicationManager app;
        private static Random random = new Random();

        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();
        }

        internal static string GenerateRandomString(int len)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, len)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        /*        [TearDown]
       public void TeardownTest()
       {
           app.Stop();
       }*/



        /*        [SetUp]
                public void SetUp()
                {
                    driver = new FirefoxDriver();
                    js = (IJavaScriptExecutor)driver;
                    vars = new Dictionary<string, object>();
                }
                [TearDown]
                public void TearDown()
                {
                    driver.Quit();
                }*/
    }
}
