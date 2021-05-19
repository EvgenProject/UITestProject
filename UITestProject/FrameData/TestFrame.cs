using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using log4net;

namespace UITestProject.FrameData
{
    [TestFixture]
    public class TestFrame <TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private static readonly string baseUrl = ConfigurationManager.AppSettings["url"];
        protected static IWebDriver driver;
        protected static ILog Log;

        private static void RunDriver()
        {
            driver = new TWebDriver();
            Log.Info($"{driver.GetType().ToString()} the driver is initialized");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeSetUp]
        public void Init()
        {
            Log = LogManager.GetLogger(GetType());
            RunDriver();
        }

        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Quit();
        }
    }
}
