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

        [FindsBy(How = How.XPath, Using = "//span[text()='Предложения продавцов']/..")]
        public IWebElement sellersOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Гарантия 12 месяцев. Код товара: 00000024598. Мы продаем только официальную продукцию. В сроке доставки указаны рабочие дни. Самовывоз из магазинов.']/../../../../div[2]/div/a[2]")]
        public IWebElement prodovec { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='product-recommended__control product-recommended__control_checkout']/a[2]")]
        public IWebElement cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='catalog-masthead-controls__input i-checkbox i-checkbox_yellow']")]
        public IWebElement comparisonButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Телевизоры']")]
        public IWebElement tvCatalogButton { get; set; }


    }
}
