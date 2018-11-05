using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCS
{
    [TestFixture]
    public class SeleniumTag
    {
        IWebDriver driver;
        DesiredCapabilities capability;
	    public static String USERNAME = "yoni27";
        public static String AUTOMATE_KEY = "nrA3qNRqvEHGyEow7LjD";
        public static String URL = "https://" + USERNAME + ":" + AUTOMATE_KEY + "@hub-cloud.browserstack.com/wd/hub";

        [OneTimeSetUp]
        public void start()
        {
            capability = new DesiredCapabilities();
            capability.SetCapability("browser", "Chrome");
            capability.SetCapability("browser_version", "62.0");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("os_version", "10");
            capability.SetCapability("resolution", "1920x1080");
            capability.SetCapability("browserstack.user", "yoni27");
            capability.SetCapability("browserstack.key", "nrA3qNRqvEHGyEow7LjD");

            driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://atidcollege.co.il/selenium-tag/");
        }

        [OneTimeTearDown]
        public void close()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }

        [Test]
        public void SeleniumTag()
        {
            
        }
    }
}
