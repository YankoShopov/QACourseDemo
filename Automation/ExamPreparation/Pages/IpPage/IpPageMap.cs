using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation.Pages.IpPage
{
    public partial class IpPage
    {
        public IWebElement PeerGuardian => Driver.FindElement(By.XPath(@"/html/body/form/input[3]"));

        public IWebElement Generate => Driver.FindElement(By.XPath(@"/html/body/form/input[5]"));

        public List<IWebElement> Names => 
            Driver.FindElement(By.XPath(@"/html/body/table/tbody"))
            .FindElements(By.TagName("a")).ToList();

        public IWebElement Search => Driver.FindElement(By.Name("countrys"));

        public string Ips => Driver.FindElement(By.XPath(@"/html/body/pre")).Text;

    }
}
