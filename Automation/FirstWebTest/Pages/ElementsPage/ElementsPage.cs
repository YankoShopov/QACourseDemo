namespace FirstWebTest.Pages.ElementsPage
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public partial class ElementsPage:BasePage
    {
        
        public ElementsPage(IWebDriver driver)
            :base(driver)
        {
            this.Url = base.Url + "/elements";
        }

     


    }
}
