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


namespace UnitTestProject1
{
    public class Origin
    {
        public static IWebDriver driver;
        public static IWebDriver SetDriver(string browser)
        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
                driver.Url = "https://www.aliexpress.com/";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.ClassName("_34l2i")).Click();
            }
            return driver;
        }

        #region SendKeys
        public void SendKeysMethod(By locator, string text)
        {
            if (driver.FindElement(locator).GetAttribute("value") != " ")
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            else
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
        #endregion

        #region SimpleClick
        public void clickElement(By locator)
        {

            driver.FindElement(locator).Click();

        }
        #endregion

        #region Driver.Close
        public static void Close()
        {

            driver.Close();

        }
        #endregion

        #region Click
        public void clickWebElement(IWebElement element, IWebDriver driver)
        {
            try
            {
                element.Click();
            }
            catch (WebDriverException e)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", element);
            }
        }
        #endregion

        #region FindElement
        public void findElement(By locator, double timeoutInSeconds = 60)
        {
            if (timeoutInSeconds == 0)
            {
                driver.FindElement(locator);
                clickElement(locator);
            }
            else
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                clickElement(locator);
            }


        }
        #endregion

        #region DropDown
        public void dropdown(By loc, string type, string value)
        {
            IWebElement element = driver.FindElement(loc);
            SelectElement drpdwn = new SelectElement(element);
            if (type == "value")
            {
                drpdwn.SelectByValue(value);
                element.Click();
            }

            else if (type == "text")
            {
                drpdwn.SelectByText(value);
                element.Click();
            }

            else if (type == "index")
            {
                drpdwn.SelectByIndex(Convert.ToInt32(value));
                element.Click();
            }
        }
        #endregion
    }
}


