using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='auth-bar__item auth-bar__item--text']")]
        public IWebElement authButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@tabindex='1']")]
        public IWebElement searchBar { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='b-main-navigation__text'][text()='Каталог']")]
        public IWebElement catalogButton { get; set; }


    }
}
