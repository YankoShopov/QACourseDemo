namespace ExamPreparation
{
    using ExamPreparation.Pages.CoutryPage;
    using ExamPreparation.Pages.IndexPage;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class FlagPedia
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
        public void ExtractAllFlagsInTheWorld()
        {
            var indexPage = new IndexPage(_driver);
            var countyPage = new CountryPage(_driver);
            indexPage.NavigateToStringUrl("https://flagpedia.net/index#t");

            var countryNames = indexPage.GetNames();
            
            foreach (var element in countryNames)
            {
                var a = element;
                if (element.Contains("Bahamas"))
                {
                    var b = "the-bahamas";
                    a = b;
                }
                if (element.Contains("Côte d'Ivoire"))
                {
                    var b = "cote-d-ivoire";
                    a = b;
                }
                
                string url = "https://flagpedia.net/" + a;
                countyPage.NavigateToStringUrl(url);
                IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                Thread.Sleep(1400);
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                   screenshot.SaveAsFile(Path.GetFullPath(@"../../../Screenshots/") + BuildName(countyPage) + ".png",ScreenshotImageFormat.Png);
          
            }
            
            
        }

        private string BuildName(CountryPage countryPage)
        {
            return $"{countryPage.Name.Text}-{countryPage.Capital.Text}-{countryPage.Code.Text}";
        }
    }
}
