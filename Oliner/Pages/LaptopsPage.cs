using Onliner.WebElementExtension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Onliner.Pages
{
    public class LaptopsPage
    {
        public const string ASUS = "(//span[@class='i-checkbox']//input[@value='asus'])[1]/..";
        public const string MIN_FREQUENCY_DROP_DOWN_MENU = "(//span[text()='Частота матрицы']/parent::div/parent::div//select[@class='schema-filter-control__item'])[1]";
        public const string MAX_FREQUENCY_DROP_DOWN_MENU = "(//span[text()='Частота матрицы']/parent::div/parent::div//select[@class='schema-filter-control__item'])[2]";
        public const string SUPER_PRICE = "//div[@class='schema-filter__facet schema-filter__facet_specific']//span[@class='i-checkbox']";
        public const string LAPTOPS_PAGE_TITLE = "//h1[text()='Ноутбуки']";
        public const string FILTER_CONTAINER_ASUS = "//span[@class='schema-tags__text'][text()='ASUS']";
        public const string FILTER_CONTAINER_MIN_MAX_FREQUENCY = "//span[@class='schema-tags__text'][text()='120 Гц — 165 Гц']";
        public const string FILTER_CONTAINER_SUPER_PRICE = "//span[@class='schema-tags__text'][text()='Суперцена']";
        public const string ELEMENT_CONTAINER = "//div[@class='js-schema-results schema-grid__center-column']";

        public MyWebElement Asus => new MyWebElement(By.XPath(ASUS));
        public SelectElement MinFrequencyDropDownMenu = new SelectElement(Driver.driver.FindElement(By.XPath(MIN_FREQUENCY_DROP_DOWN_MENU)));
        public SelectElement MaxFrequencyDropDownMenu = new SelectElement(Driver.driver.FindElement(By.XPath(MAX_FREQUENCY_DROP_DOWN_MENU)));
        public MyWebElement SuperPrice => new MyWebElement(By.XPath(SUPER_PRICE));
        public MyWebElement LaptopsPageTitle => new MyWebElement(By.XPath(LAPTOPS_PAGE_TITLE));
        public MyWebElement FilterContainerAsus => new MyWebElement(By.XPath(FILTER_CONTAINER_ASUS));
        public MyWebElement FilterContainerMinMaxFrequency => new MyWebElement(By.XPath(FILTER_CONTAINER_MIN_MAX_FREQUENCY));
        public MyWebElement FilterContainerSuperPrice => new MyWebElement(By.XPath(FILTER_CONTAINER_SUPER_PRICE));
        public MyWebElement ElementsContainer => new MyWebElement(By.XPath(ELEMENT_CONTAINER));

        public void ClickAsusCheckBox()
        {
            Asus.WaitForElementIsDisplayed();
            Asus.Click();
        }

        public void ChangeMinFrequency()
        {
            MinFrequencyDropDownMenu.SelectByValue("120hz");
        }

        public void ChangeMaxFrequency()
        {
            MaxFrequencyDropDownMenu.SelectByValue("165hz");
        }

        public void ClickSuperPriceCheckBox()
        {
            SuperPrice.Click();
        }

        public bool SuperPriceProductCount()
        {
            ElementsContainer.WaitForElementIsDisplayed();
            var Products = ElementsContainer.FindElements(By.XPath(".//span[@data-bind='html: product.extended_name || product.full_name']"));
            ElementsContainer.WaitForElementIsDisplayed();
            var SuperPriceBanner = ElementsContainer.FindElements(By.XPath(".//div[@class='schema-product__hot']"));
            
            return Products.Count == SuperPriceBanner.Count;
        }
    }
}
