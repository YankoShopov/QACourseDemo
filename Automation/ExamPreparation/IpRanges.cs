namespace ExamPreparation
{
    using ExamPreparation.Pages.CoutryPage;
    using ExamPreparation.Pages.IndexPage;
    using ExamPreparation.Pages.IpPage;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class IpRanges
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void ExtractAllIpsInTheWorld()
        {
            var ipPage = new IpPage(_driver);

            ipPage.NavigateToStringUrl("http://services.ce3c.be/ciprg/");


            var names = ipPage.GetNames();

            
            foreach (var name in names)
            {
                ipPage.Search.Clear();
                ipPage.Search.SendKeys(name);
                ipPage.PeerGuardian.Click();
                ipPage.Generate.Click();
                File.WriteAllText(Path.GetFullPath($@"../../../CountryIp/{name}.txt"), ipPage.Ips);
                _driver.Navigate().Back();

                
            }

           
            

        }

        
    }
}

