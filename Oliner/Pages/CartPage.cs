using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class CartPage
    {
        public CartPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='button-style button-style_small cart-form__button button-style_primary']")]
        public IWebElement orderButton { get; set; }
    }
}
