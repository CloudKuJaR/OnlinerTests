using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class ProductPage
    {
        public ProductPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = SELLERS_OFFERS)]
        public IWebElement sellersOffers { get; set; }

        [FindsBy(How = How.XPath, Using = SELLER)]
        public IWebElement prodovec { get; set; }

        [FindsBy(How = How.XPath, Using = CART)]
        public IWebElement cart { get; set; }

        [FindsBy(How = How.XPath, Using = COMPARISON_BUTTON)]
        public IWebElement comparisonButton { get; set; }

        [FindsBy(How = How.XPath, Using = TV_CATALOG_BUTTON)]
        public IWebElement tvCatalogButton { get; set; }

        public const string SELLERS_OFFERS = "//span[text()='Предложения продавцов']/..";
        public const string SELLER = "//div[text()='Гарантия 12 месяцев. Код товара: 00000024598. Мы продаем только официальную продукцию. В сроке доставки указаны рабочие дни. Самовывоз из магазинов.']/../../../../div[2]/div/a[2]";
        public const string CART = "//div[@class='product-recommended__control product-recommended__control_checkout']/a[2]";
        public const string COMPARISON_BUTTON = "//span[@class='catalog-masthead-controls__input i-checkbox i-checkbox_yellow']";
        public const string TV_CATALOG_BUTTON = "//span[text()='Телевизоры']";
    }
}
