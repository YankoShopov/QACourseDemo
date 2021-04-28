namespace ExamPreparation.Pages.IpPage
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class IpPage:BasePage
    {
        public IpPage(IWebDriver driver) 
            : base(driver)
        {

        }
        //New Method
        public List<string> GetNames()
        {
            var list = new List<string>();
            foreach (var element in this.Names)
            {
               
                    list.Add(element.Text);
                //Return List
            }
            return list;
        }

    }
}
