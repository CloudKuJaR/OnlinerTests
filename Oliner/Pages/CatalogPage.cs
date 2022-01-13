using Onliner.WebElementExtension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class CatalogPage
    {

        public const string TV = "//a[@href='https://catalog.onliner.by/tv']";
        public const string ELECTRONICS = "//li[@data-id='1']";
        public const string TV_AND_VIDEO = "//a[@href='https://catalog.onliner.by/tv']/../../..";

        public MyWebElement Tv => new MyWebElement(By.XPath(TV));
        public MyWebElement Electronics => new MyWebElement(By.XPath(ELECTRONICS));
        public MyWebElement TvAndVideo => new MyWebElement(By.XPath(TV_AND_VIDEO));

        public void NavigateToTvPage()
        {
            Electronics.Click();
            TvAndVideo.Click();
            Tv.Click();
        }

    }
}
