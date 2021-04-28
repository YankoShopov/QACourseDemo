namespace FirstWebTest.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class BasePage
    {
        private IWebDriver driver;
        private string url= "https://demoqa.com";

        public IWebDriver Driver { get => driver;private set => driver = value; }
       

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WebDriverWait Wait => new WebDriverWait(this.Driver, TimeSpan.FromSeconds(2));

        public string Url { get => url; set => url = value; }

       //Second comment

        protected void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
        }
    }
}
