using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FirstWebTest.Pages.ElementsPage.TextBoxPage
{
    public partial class TextBoxPage : BasePage
    {
        public TextBoxPage(IWebDriver driver) 
            : base(driver)
        {
            this.Url = base.Url + "/text-box";
        }

       
        public void FillRegistrationForm()
        {
            this.Type(FullName, "Pesho");
            this.Type(Email, "114@abv.bg");
            this.Type(CurrentAddress, "GSHSGD");
            this.Type(PermanentAddress, "DSDADS");
            Thread.Sleep(2000);
            SubmitButton.Click();
        }
    }
}
