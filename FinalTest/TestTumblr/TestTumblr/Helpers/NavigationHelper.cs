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
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        WebDriverWait wait;
        public NavigationHelper(ApplicationManager manager, string baseURL, WebDriverWait wait)
                    : base(manager)
        {
            this.baseURL = baseURL;
            this.wait = wait;
        }


        public void OpenMenuOfEditQuote()
        {
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".\\_3jtQS svg")).Click();
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".\\_3PZ7G > svg")).Click();
            driver.SwitchTo().Frame(2);
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".quote-field .editor")).Click();
        }

        public void OpenMenuOfEditPosts()
        {
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".\\_3jtQS svg")).Click();
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".\\_1u3LN > svg")).Click();
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.SwitchTo().Frame(2);
            driver.FindElement(By.CssSelector(".title-field .editor")).Click();
        }

        public void OpenPosts()
        {
            driver.Navigate().GoToUrl("https://www.tumblr.com/blog/aeko-love");
            /*            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                        driver.FindElement(By.CssSelector(".\\_3ntD6:nth-child(6) path")).Click();
                        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                        driver.FindElement(By.CssSelector("li:nth-child(1) > a > span:nth-child(1)")).Click();
                        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                        wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));*/
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1295, 695);
        }
    }
}
