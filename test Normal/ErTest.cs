// Generated by Selenium IDE
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
[TestFixture]
public class ErTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void er() {
    driver.Navigate().GoToUrl("https://www.tumblr.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1295, 695);
    driver.FindElement(By.CssSelector("#signup_login_button > .signup_get_started_btn")).Click();
    driver.FindElement(By.Id("signup_determine_email")).Click();
    driver.FindElement(By.Id("signup_determine_email")).SendKeys("shakirova139@gmail.com");
    driver.FindElement(By.CssSelector(".signup_determine_btn")).Click();
    driver.FindElement(By.LinkText("Войти с паролем")).Click();
    driver.FindElement(By.Id("signup_password")).SendKeys("shakirova-love");
    driver.FindElement(By.CssSelector(".signup_login_btn")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".\\_1DxdS:nth-child(1) .\\_2zTTs .Hi_aW"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.CssSelector("li:nth-child(1) > .\\_1gkvT")).Click();
    {
      var element = driver.FindElement(By.CssSelector("li:nth-child(1) > .\\_1gkvT"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.SwitchTo().Frame(2);
    driver.FindElement(By.CssSelector(".title-field .editor")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".has-text"));
      js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<span>fesn</span>'}", element);
    }
    driver.FindElement(By.CssSelector(".editor-richtext")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".editor-richtext"));
      js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<p>sebfjh<br></p>'}", element);
    }
    driver.FindElement(By.CssSelector(".button-area")).Click();
    driver.SwitchTo().DefaultContent();
    {
      var element = driver.FindElement(By.CssSelector(".\\_3bP9O:nth-child(3) .\\_3zfRI > .KeFJu"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
  }
}
