using Onliner.WebElementExtension;
using OpenQA.Selenium;


namespace Onliner.Pages
{
    public class OrderPage
    {
        private const string ONLINER_BUTTON = "//a[@href='https://www.onliner.by']";
        private const string ORDER_TEXT = "//div[@class='cart-form__title cart-form__title_big-alter cart-form__title_extended-alter']";
        private const string PRICE = "//div[contains(@class,' cart-form__description_primary cart-form__description_base cart-form__description_ellipsis')]";

        public MyWebElement OnlinerButton => new MyWebElement(By.XPath(ONLINER_BUTTON));
        public MyWebElement OrderText => new MyWebElement(By.XPath(ORDER_TEXT));
        public MyWebElement Price => new MyWebElement(By.XPath(PRICE));

        public void OpenCatalogButton() => OnlinerButton.Click();

    }
}
