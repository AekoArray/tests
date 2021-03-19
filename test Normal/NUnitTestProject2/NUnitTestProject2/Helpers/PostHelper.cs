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
    public class PostHelper : HelperBase
    {
        WebDriverWait wait;
        public PostHelper(ApplicationManager manager, WebDriverWait wait)
    : base(manager)
        {
            this.wait = wait;
        }

        public void CreatePost(PostData post)
        {
            {
                wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                driver.FindElement(By.ClassName("editor")).SendKeys(post.Title);
            }
            driver.FindElement(By.CssSelector(".editor-richtext")).Click();
            {
                driver.FindElement(By.CssSelector(".editor-richtext")).SendKeys(post.Description);
            }
            driver.FindElement(By.CssSelector(".button-area")).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void DeletePost()
        {
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_33VXm:nth-child(5) svg:nth-child(1)")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_33VXm:nth-child(5) svg:nth-child(1)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.CssSelector(".\\_16Les:nth-child(2) > .Hi_aW")).Click();
        }

        public PostData GetCreatedPostData()
        {
            string title = driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_2m1qj:nth-child(1)")).Text;
            string description = driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_2m1qj:nth-child(2)")).Text;
            return new PostData(title, description);
        }

        public void EditPost(PostData post)
        {
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_33VXm:nth-child(6) svg:nth-child(1)")).Click();
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            {
                var element = driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_33VXm:nth-child(6) svg:nth-child(1)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.SwitchTo().Frame(2);
            driver.FindElement(By.CssSelector(".has-text")).Click();
            {
                driver.FindElement(By.ClassName("editor")).SendKeys(post.Title);
            }
            driver.FindElement(By.CssSelector(".editor-richtext")).Click();
            {
                driver.FindElement(By.CssSelector(".editor-richtext")).SendKeys(post.Description);
            }
            driver.FindElement(By.CssSelector(".button-area")).Click();
        }

        public PostData GetEditPostData(PostData post, PostData postNew)
        {
            string title = post.Title + postNew.Description;
            string description = post.Description + postNew.Description;
            PostData editPost = new PostData(title, description);
            return editPost;
        }
    }
}
