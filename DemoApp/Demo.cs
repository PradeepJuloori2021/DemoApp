using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void MyFristTestCase()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.ust.com/";
            System.Threading.Thread.Sleep(3000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
