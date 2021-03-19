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
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager manager)
    : base(manager)
        {
        }

        public void Login(AccountData user)
        {
            driver.FindElement(By.CssSelector("#signup_login_button > .signup_get_started_btn")).Click();
            driver.FindElement(By.Id("signup_determine_email")).SendKeys(user.Email);
            driver.FindElement(By.Id("signup_forms_submit")).Click();
            driver.FindElement(By.LinkText("Войти с паролем")).Click();
            driver.FindElement(By.Id("signup_password")).SendKeys(user.Password);
            driver.FindElement(By.CssSelector(".signup_login_btn")).Click();
        }
    }
}
