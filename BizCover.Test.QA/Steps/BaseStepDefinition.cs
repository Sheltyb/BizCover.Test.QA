using BizCover.Test.QA.Core;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using TechTalk.SpecFlow;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class BaseStepDefinition
    {
        public static IWebDriver driver = null;
 

        [BeforeTestRun]
        private static void WarmUpIis()
        {
            var webClient = new WebClient { Proxy = null };
            var configBuilder = new ConfigurationBuilder();
            var config = configBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("specflow.json")
                .Build();

            ConfigSettings.TestCaseURL = config["URL"];
            ConfigSettings.DriverType = config["DriverType"];
            webClient.DownloadString(ConfigSettings.TestCaseURL);
        }

        [Before]
        private void BeforeScenario()
        {
            driver = WebDriverFactory.CreateDriver((DriverType)Enum.Parse(typeof(DriverType), ConfigSettings.DriverType));
        }

        [After]
        private void Teardown()
        {
            driver.Quit();
        }

        [AfterStep]
        private void AfterStep()
        {
            if (ScenarioContext.Current.TestError == null)
            {
                return;
            }

            Console.WriteLine("INFO: Failed at URL:" + driver.Url);
        }
    }
}
