using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace ExamPreparation.Pages.CoutryPage
{
    public partial class CountryPage
    {

        public IWebElement Name => Driver.FindElement(By.XPath(@"//*[@id=""content""]/table/tbody/tr[3]/td"));
        //*[@id=""content""]/table/tbody/tr[3]
        //*[@id="content"]/table/tbody/tr[3]/td
        //*[@id="content"]/table/tbody/tr[3]/th

        public IWebElement Capital => Driver.FindElement(By.XPath(@"//*[@id=""content""]/table/tbody/tr[4]/td"));

        public IWebElement Code => Driver.FindElement(By.XPath(@"//*[@id=""content""]/table/tbody/tr[2]/td"));


    }
}
