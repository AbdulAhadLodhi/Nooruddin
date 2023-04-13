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
namespace UnitTestProject1.Add_to_Cart
{
    public class WebElements_and_Methods2 : Origin
    {
        
        By outdoor = By.XPath("/html/body/div[3]/div[5]/div[1]/div/div/div[2]/div/div/div[2]/dl[10]/dt/span/a");

        By hiking = By.XPath("/html/body/div[4]/div[1]/div/div[1]/div[1]/div[2]/div/div/ul/li/ul/li[18]/a");
        By shoes = By.XPath("/html/body/div[4]/div[1]/div/div[1]/div[1]/div[2]/div/div/ul/li[3]/ul/li[13]/a");
        By shoe = By.XPath("/html/body/div[4]/div[1]/div/div[2]/div/div[2]/div[3]/a[10]");
        By cart = By.ClassName("addcart");

        public void add_to_cart()
        {
            Origin.SetDriver("Chrome");
            Thread.Sleep(10000);

            clickElement(outdoor);

            clickElement(hiking);
            clickElement(shoe); 
            clickElement(shoes);
            clickElement(cart);

        }

    }

}
