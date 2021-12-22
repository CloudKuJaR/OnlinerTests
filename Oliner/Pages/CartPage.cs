using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class CartPage
    {
        public CartPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ORDER_BUTTON)]
        public IWebElement orderButton { get; set; }

        public const string ORDER_BUTTON = "//a[@class='button-style button-style_small cart-form__button button-style_primary']";
    }
}
