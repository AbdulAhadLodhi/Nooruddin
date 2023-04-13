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
using UnitTestProject1.SignIn;

namespace UnitTestProject1.Add_to_Cart
{
    [TestClass]
    public class Add_to_Cart
    {

        WebElements_and_Methods2 obj = new WebElements_and_Methods2();
        [TestMethod]
        public void addtocart()
        {
            Origin.SetDriver("Chrome");
            obj.add_to_cart();

        }

    }
}
