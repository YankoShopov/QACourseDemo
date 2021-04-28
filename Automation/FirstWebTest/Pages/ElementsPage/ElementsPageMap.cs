using OpenQA.Selenium;
using System.Collections.Generic;

namespace FirstWebTest.Pages.ElementsPage
{
    public partial class ElementsPage
    {
        public IWebElement Elements => this.Driver.FindElement(By.XPath(@"//*[@id=""app""]/div/div/div[2]/div[1]/div/div/div[1]/div"));

        public IWebElement TextBox => this.Driver.FindElement(By.Id("item-0"));
        //Main new
      
    }
}
