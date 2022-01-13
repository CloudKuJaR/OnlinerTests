using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class CartPage
    {
        public const string ORDER_BUTTON = "//a[@class='button-style button-style_small cart-form__button button-style_primary']";
        public const string DELETE_BUTTON = "//div[@class='cart-form__offers-flex']//a[contains(@class,'cart-form__button_remove')]";
        public const string HOME_PAGE_BUTTON = "//a[@href='https://www.onliner.by']";
        public const string TV_NAME = "//a[@href='https://catalog.onliner.by/tv/lg/65up75006lf'][@class='cart-form__link cart-form__link_primary cart-form__link_base-alter']";
        public const string QUANTITY_OF_PRODUCT = "//div[@class='cart-form__description cart-form__description_base cart-form__description_ellipsis cart-form__description_condensed-other']";

        public MyWebElement OrderButton => new MyWebElement(By.XPath(ORDER_BUTTON));
        public MyWebElement DeleteButton => new MyWebElement(By.XPath(DELETE_BUTTON));
        public MyWebElement HomePageButton => new MyWebElement(By.XPath(HOME_PAGE_BUTTON));
        public MyWebElement TvName => new MyWebElement(By.XPath(TV_NAME));
        public MyWebElement QuantityOfProduct => new MyWebElement(By.XPath(QUANTITY_OF_PRODUCT));


        public void ClickOrderButton()
        {
            OrderButton.Click();
        }

        public void OpenHomePageButton()
        {
            HomePageButton.Click();
        }
        public void ClickToDeleteButton()
        {
            DeleteButton.HoverOver();
            DeleteButton.Click();
        }
    }
}
