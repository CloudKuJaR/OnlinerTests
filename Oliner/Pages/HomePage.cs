using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class HomePage
    {
        private const string CARS_ARTICLE_TEASER = "(//h2//a[text()='Лайфстайл']/parent::h2/parent::header/parent::div//li[@class='b-teasers-2__teaser'])[1]";
        private const string USER_SUPPORT_PAGE = "//a[@href='https://support.onliner.by/']";
        private const string CURRENCY_CONVESRION_PAGE = "//a[@href='https://kurs.onliner.by/']";
        private const string HOUSES_AND_FLATS_PAGE = "//li[@class='b-main-navigation__item b-main-navigation__item_arrow']//a[@href='https://r.onliner.by/pk']";

        private MyWebElement CarsArticleTeaser => new MyWebElement(By.XPath(CARS_ARTICLE_TEASER));
        private MyWebElement UserSupportPage => new MyWebElement(By.XPath(USER_SUPPORT_PAGE));
        private MyWebElement CurrencyConversionPage => new MyWebElement(By.XPath(CURRENCY_CONVESRION_PAGE));
        private MyWebElement HousesAndFlats => new MyWebElement(By.XPath(HOUSES_AND_FLATS_PAGE));

        public void OpenCarsArticleTeaser() => CarsArticleTeaser.Click();

        public void OpenUserSupprotPage() => UserSupportPage.Click();

        public void OpenCurrencyConversionPage() => CurrencyConversionPage.Click();

        public void OpenHousesAndFlatsPage() => HousesAndFlats.Click();
    }
}
