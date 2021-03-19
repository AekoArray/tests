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

namespace TestTumblr
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        public IJavaScriptExecutor js;

        private NavigationHelper navigation;
        private LoginHelper auth;
        private PostHelper post;
        private QuoteHelper quote;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public static ApplicationManager GetInstance()
        {

            if (!app.IsValueCreated)

            {

                ApplicationManager newInstance = new ApplicationManager();

                newInstance.Navigation.OpenHomePage();

                app.Value = newInstance;

            }
            return app.Value;
        }


        private ApplicationManager()
        {
            string baseURL = "https://www.tumblr.com/";
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            var timeout = 50000;
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
            navigation = new NavigationHelper(this, baseURL, wait);
            auth = new LoginHelper(this);
            post = new PostHelper(this, wait);
            quote = new QuoteHelper(this, wait);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
        }

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        public void Stop()
        {
            driver.Quit();
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return auth;
            }
        }

        public PostHelper Post
        {
            get
            {
                return post;
            }
        }

        public QuoteHelper Quote
        {
            get
            {
                return quote;
            }
        }
    }
}
