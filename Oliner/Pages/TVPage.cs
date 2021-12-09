using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onliner.Pages
{
    public class TVPage
    {
        public TVPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Телевизор Samsung QE65QN90AAU']/..")] //    Телевизор Samsung QE65QN90AAU Телевизор LG 55NANO926PB
        public IWebElement product1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Телевизор LG 55NANO926PB']/..")] //    Телевизор Samsung QE65QN90AAU Телевизор LG 55NANO926PB
        public IWebElement product2 { get; set; }
    }
}
