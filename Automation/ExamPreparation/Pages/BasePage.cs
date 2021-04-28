namespace ExamPreparation.Pages
{

    using OpenQA.Selenium;

    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public void NavigateToStringUrl(string url)
        {
            this.Driver.Url = url;
        }


    }
}
