using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using UITestProject.FrameData;

namespace UITestProject
{
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    public class Test<TWebDriver> : TestFrame<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        [Test]
        public void TestCase()
        {
            Console.WriteLine(driver.Title);
        }
    }
}
