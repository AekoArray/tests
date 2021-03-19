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
    public class QuoteHelper : HelperBase
    {
        WebDriverWait wait;
        public QuoteHelper(ApplicationManager manager, WebDriverWait wait)
            : base(manager)
        {
            this.wait = wait;
        }


        public void CreateQuote(QuoteData quote)
        {
            {
                driver.FindElement(By.ClassName("editor")).SendKeys(quote.Title);
            }
            driver.FindElement(By.CssSelector("p")).Click();
            {
                driver.FindElement(By.CssSelector(".editor-richtext")).SendKeys(quote.Description);
            }
            driver.FindElement(By.CssSelector(".button-area")).Click();
        }

        public void EditQuote(QuoteData quote)
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
                driver.FindElement(By.ClassName("editor")).SendKeys(quote.Title);
            }
            driver.FindElement(By.CssSelector(".editor-richtext")).Click();
            {
                driver.FindElement(By.CssSelector(".editor-richtext")).SendKeys(quote.Description);
            }
            driver.FindElement(By.CssSelector(".button-area")).Click();
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(2) .\\_33VXm:nth-child(5) svg:nth-child(1)")).Click();
        }

    }
}
