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
public class Testtumblr2Test {
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
  public void testtumblr2() {
    driver.Navigate().GoToUrl("https://www.tumblr.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1295, 695);
    driver.FindElement(By.CssSelector("#signup_login_button > .signup_get_started_btn")).Click();
    driver.FindElement(By.Id("signup_determine_email")).SendKeys("shakirova139@gmail.com");
    driver.FindElement(By.CssSelector(".signup_determine_btn")).Click();
    driver.FindElement(By.LinkText("Войти с паролем")).Click();
    driver.FindElement(By.Id("signup_password")).SendKeys("shakirova-love");
    driver.FindElement(By.CssSelector(".signup_login_btn")).Click();
    driver.FindElement(By.CssSelector(".\\_3jtQS svg")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".\\_3bP9O:nth-child(1) .\\_3zfRI > .KeFJu"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".\\_3e9MM"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".\\_1u3LN > svg")).Click();
    driver.SwitchTo().Frame(3);
    driver.FindElement(By.CssSelector(".title-field .editor")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".has-text"));
      js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<span>Test 2<br></span>'}", element);
    }
    driver.FindElement(By.CssSelector(".editor-richtext")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".editor-richtext"));
      js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<p>hi test<br></p>'}", element);
    }
    driver.FindElement(By.CssSelector(".button-area")).Click();
  }
}
