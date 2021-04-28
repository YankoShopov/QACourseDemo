namespace FirstWebTest
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;
    using FirstWebTest.Pages.ElementsPage;
    using FluentAssertions;
    using FirstWebTest.Pages.ElementsPage.TextBoxPage;

    [TestFixture]
    public class DemoQAChrome
    {
        private IWebDriver driver;
        private ElementsPage elementsPage;
        private TextBoxPage textBoxPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            elementsPage = new ElementsPage(driver);
            textBoxPage = new TextBoxPage(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
        [Test]
        public void ElementsPageTextBox()
        {
            elementsPage.NavigateTo();          
            elementsPage.Elements.Click();
            
            StringAssert.Contains("Text Box", elementsPage.TextBox.Text);

        }
       [Test]
        public void RegistrateWithValidData()
        {
            textBoxPage.NavigateTo();
            textBoxPage.FillRegistrationForm();

            var name = this.driver.FindElement(By.Id("name"));
            var email = this.driver.FindElement(By.Id("email"));
            var address = this.driver.FindElement(By.XPath(@"//*[@id=""currentAddress""]"));
            var permanent = this.driver.FindElement(By.XPath(@"//*[@id=""permanentAddress""]"));
            Thread.Sleep(2000);
            Assert.AreEqual(name.Displayed, textBoxPage.FullName.Displayed);
            Assert.AreEqual(email.Displayed, textBoxPage.Email.Displayed);
            Assert.AreEqual(address.Displayed, textBoxPage.CurrentAddress.Displayed);
            Assert.AreEqual(permanent.Displayed, textBoxPage.PermanentAddress.Displayed);
        }
    }
}
