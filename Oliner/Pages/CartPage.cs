using Onliner.ActionsWaits;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using Onliner.WebElementExtension;

namespace Onliner.Pages
{
    public class CartPage
    {
        public const string ORDER_BUTTON = "//a[@class='button-style button-style_small cart-form__button button-style_primary']";
        public const string DELETE_BUTTON = "//div[@class='cart-form__offers-flex']//a[contains(@class,'cart-form__button_remove')]";
        public const string HOME_PAGE_BUTTON = "//a[@href='https://www.onliner.by']";


        public MyWebElement OrderButton => new MyWebElement(By.XPath(ORDER_BUTTON));
        public MyWebElement DeleteButton => new MyWebElement(By.XPath(DELETE_BUTTON));
        public MyWebElement HomePageButton => new MyWebElement(By.XPath(HOME_PAGE_BUTTON));



        public void ClickOrderButton()
        {
            OrderButton.Click();
        }

        public void ClickHomePageButton()
        {
            HomePageButton.Click();
        }
        //изменить
        public void ClickDeleteButton()
        {
            DeleteButton.HoverOver();
            DeleteButton.Click();
        }
    }
}
