using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class HomePage
    {
        public const string CARS_ARTICLE_TEASER = "(//h2//a[text()='Авто']/parent::h2/parent::header/parent::div//li[@class='b-teasers-2__teaser'])[1]";
        public const string USER_SUPPORT_PAGE = "//a[@href='https://support.onliner.by/']";

        public MyWebElement CarsArticleTeaser => new MyWebElement(By.XPath(CARS_ARTICLE_TEASER));
        public MyWebElement UserSupportPage => new MyWebElement(By.XPath(USER_SUPPORT_PAGE));

        public void OpenCarsArticleTeaser()
        {
            CarsArticleTeaser.Click();
        }

        public void OpenUserSupprotPage()
        {
            UserSupportPage.Click();
        }
    }
}
