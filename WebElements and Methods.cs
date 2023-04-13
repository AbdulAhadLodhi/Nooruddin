using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Edge;

namespace UnitTestProject1.SignIn
{
    internal class WebElements_and_Methods : Origin
    {
        By uname = By.Id("fm-login-id");
        By pass = By.Id("fm-login-password");
        By logBtn = By.ClassName("login-submit");

        public void sendLoginDetails(string usrnm, string pswd)
        {
            findElement(uname);
            SendKeysMethod(uname, usrnm);
            findElement(pass);
            SendKeysMethod(pass, pswd);

            clickElement(logBtn);
            Thread.Sleep(10000);
        }

    }
}

