using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ProductPage
    {
        private const string SELLERS_OFFERS = "//span[text()='Предложения продавцов']/..";
        private const string SELLER = "(//div[contains(@class,'helpers_hide_tablet')]//a[@class='button-style button-style_base-alter offers-list__button offers-list__button_cart button-style_expletive'])[3]";
        private const string CART = "//div[@class='product-recommended__control product-recommended__control_checkout']/a[2]";
        private const string COMPARISON_BUTTON = "//span[@class='catalog-masthead-controls__input i-checkbox i-checkbox_yellow']";
        private const string TV_CATALOG_BUTTON = "//span[text()='Телевизоры']";
        private const string CONFIRM_CITY_BUTTON = "//span[@class='button-style button-style_another button-style_base offers-form__button']";
        private const string PRODUCT_NAME = "//h1[@class='catalog-masthead__title']";

        private MyWebElement SellersOffers => new MyWebElement(By.XPath(SELLERS_OFFERS));
        private MyWebElement Seller => new MyWebElement(By.XPath(SELLER));
        private MyWebElement Cart => new MyWebElement(By.XPath(CART));
        private MyWebElement ComparisonButton => new MyWebElement(By.XPath(COMPARISON_BUTTON));
        private MyWebElement TvCatalogButton => new MyWebElement(By.XPath(TV_CATALOG_BUTTON));
        private MyWebElement ConfirmCityButton => new MyWebElement(By.XPath(CONFIRM_CITY_BUTTON));
        private MyWebElement ProductName => new MyWebElement(By.XPath(PRODUCT_NAME));

        public void ClickSellersOffersButton() => SellersOffers.Click();

        public void ClickSellerButton() => Seller.Click();

        public void ClickCartButton() => Cart.Click();

        public void ClickComparisonButton() => ComparisonButton.Click();

        public void ClickTvCatalogButton() => TvCatalogButton.Click();

        public void SelectCity() => ConfirmCityButton.Click();

        public string GetProductName() => ProductName.Text;
    }
}
