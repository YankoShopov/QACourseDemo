using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstWebTest.Pages.ElementsPage.TextBoxPage
{
    public partial class TextBoxPage
    {
        public IWebElement FullName => this.Driver.FindElement(By.Id("userName"));

        public IWebElement Email => this.Driver.FindElement(By.Id("userEmail"));

        public IWebElement CurrentAddress => this.Driver.FindElement(By.Id("currentAddress"));

        public IWebElement PermanentAddress => this.Driver.FindElement(By.Id("permanentAddress"));

        public IWebElement SubmitButton => this.Driver.FindElement(By.Id("submit"));
    }
}
