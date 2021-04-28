namespace ExamPreparation.Pages.IndexPage
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class IndexPage : BasePage
    {
        public IndexPage(IWebDriver driver) 
            : base(driver)
        {

        }

        public List<string> GetNames()
        {
            var list = new List<string>();
            foreach (var element in CountryNames)
            {
                if (element.Text != "Country")
                {

                    list.Add(element.Text);
                }

            }
            return list;
        }
    }
}
