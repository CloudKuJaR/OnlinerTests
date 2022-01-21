using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class CartPage
    {
        private const string ORDER_BUTTON = "//a[@class='button-style button-style_small cart-form__button button-style_primary']";
        private const string DELETE_BUTTON = "//div[@class='cart-form__offers-flex']//a[contains(@class,'cart-form__button_remove')]";
        private const string HOME_PAGE_BUTTON = "//a[@href='https://www.onliner.by']";
        private const string TV_NAME = "//div[@class='cart-form__description cart-form__description_primary cart-form__description_base-alter cart-form__description_font-weight_semibold cart-form__description_condensed-other']//a";
        private const string QUANTITY_OF_PRODUCT = "//div[@class='cart-form__description cart-form__description_base cart-form__description_ellipsis cart-form__description_condensed-other']";
        private const string PRODUCT_PRICE = "//div[@class='cart-form__description cart-form__description_primary cart-form__description_base-alter cart-form__description_font-weight_semibold cart-form__description_ellipsis cart-form__description_condensed-other']//span";

        private MyWebElement TvName => new MyWebElement(By.XPath(TV_NAME));
        private MyWebElement QuantityOfProduct => new MyWebElement(By.XPath(QUANTITY_OF_PRODUCT));
        private MyWebElement ProductPrice => new MyWebElement(By.XPath(PRODUCT_PRICE));
        private MyWebElement OrderButton => new MyWebElement(By.XPath(ORDER_BUTTON));
        private MyWebElement DeleteButton => new MyWebElement(By.XPath(DELETE_BUTTON));
        private MyWebElement HomePageButton => new MyWebElement(By.XPath(HOME_PAGE_BUTTON));

        // <FIX> OpenButton? нужно переименовать.
        public void OpenOrderPageButton() => OrderButton.Click();

        public void OpenHomePageButton() => HomePageButton.Click();

        public string GetProductPrice() => ProductPrice.Text;

        public string GetTvNameText()
        {
            TvName.WaitForElementIsDisplayed();

            return TvName.Text;
        }

        public string GetQuantityOfProductText()
        {
            QuantityOfProduct.WaitForElementIsDisplayed();

            return QuantityOfProduct.Text;
        }

        // <FIX> тут скорее уместно название DeleteProduct(). так в тесте будет красивее выглядеть само действие
        public void ClickDeleteButton()
        {
            DeleteButton.HoverOver();
            DeleteButton.Click();
        }
    }
}
