using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ProductPage
    {
        private const string SELLERS_OFFERS_BUTTON = "//span[text()='Предложения продавцов']/..";
        private const string SELLER_BUTTON = "(//div[contains(@class,'helpers_hide_tablet')]//a[@class='button-style button-style_base-alter offers-list__button offers-list__button_cart button-style_expletive'])[3]";
        private const string CART_BUTTON = "//div[@class='product-recommended__control product-recommended__control_checkout']/a[2]";
        private const string IN_CART_BUTTON = "(//a[@class='button-style button-style_base-alter offers-list__button offers-list__button_cart button-style_another'])[2]";
        private const string COMPARISON_BUTTON = "//span[@class='catalog-masthead-controls__input i-checkbox i-checkbox_yellow']";
        private const string TV_CATALOG_BUTTON = "//span[text()='Телевизоры']";
        private const string CONFIRM_CITY_BUTTON = "//span[@class='button-style button-style_another button-style_base offers-form__button']";
        private const string PRODUCT_NAME = "//h1[@class='catalog-masthead__title']";

        private MyWebElement SellersOffersButton => new MyWebElement(By.XPath(SELLERS_OFFERS_BUTTON));
        private MyWebElement SellerButton => new MyWebElement(By.XPath(SELLER_BUTTON));
        private MyWebElement CartButton => new MyWebElement(By.XPath(CART_BUTTON));
        private MyWebElement ComparisonButton => new MyWebElement(By.XPath(COMPARISON_BUTTON));
        private MyWebElement TvCatalogButton => new MyWebElement(By.XPath(TV_CATALOG_BUTTON));
        private MyWebElement ConfirmCityButton => new MyWebElement(By.XPath(CONFIRM_CITY_BUTTON));
        private MyWebElement ProductName => new MyWebElement(By.XPath(PRODUCT_NAME));
        private MyWebElement InCartButton => new MyWebElement(By.XPath(IN_CART_BUTTON));

        public void ClickSellersOffersButton() => SellersOffersButton.Click();

        public void ClickSellerButton() => SellerButton.Click();

        public void ClickComparisonButton() => ComparisonButton.Click();

        public void ClickTvCatalogButton() => TvCatalogButton.Click();

        public string GetProductName() => ProductName.Text;

        public void ClickCartButton()
        {
            if(CartButton.IsPresent())
            {
                CartButton.Click();
            }
            else
            {
                InCartButton.Click();
            }
        }

        public void SelectCity()
        {
            SellerButton.HoverOver();

            if(ConfirmCityButton.IsPresent())
            {
                ConfirmCityButton.Click();
            }
        }
    }
}
