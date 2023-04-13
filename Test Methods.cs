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
    [TestClass]
    public class Login_TM : Origin
    {
        WebElements_and_Methods obj = new WebElements_and_Methods();

        [TestMethod]
        public void LoginWithValidCredentials()
        {
            Origin.SetDriver("Chrome");

            obj.sendLoginDetails("zansf@icloud.com", "FWABBgtYRQg7z5F");
            string actualText = driver.FindElement(By.ClassName("_1_3UD")).Text;
            Assert.AreEqual("Hi, zansf", actualText);


        }
    }
}


