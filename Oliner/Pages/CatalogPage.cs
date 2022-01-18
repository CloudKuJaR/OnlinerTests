using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class CatalogPage
    {

        private const string TV = "//a[@href='https://catalog.onliner.by/tv']";
        private const string ELECTRONICS = "//li[@data-id='1']";
        private const string TV_AND_VIDEO = "//a[@href='https://catalog.onliner.by/tv']/../../..";
        private const string ELECTRONICS_TEXT = "//span[text()='Электроника']";
        private const string COMPUTER_AND_WEB = "//li[@data-id='2']";
        private const string LAPTOPS_AND_COMPUTERS = "//div[text()=' Ноутбуки, компьютеры, мониторы ']";
        private const string LAPTOPS = "//a[@href='https://catalog.onliner.by/notebook']";

        public MyWebElement Tv => new MyWebElement(By.XPath(TV));
        public MyWebElement Electronics => new MyWebElement(By.XPath(ELECTRONICS));
        public MyWebElement TvAndVideo => new MyWebElement(By.XPath(TV_AND_VIDEO));
        public MyWebElement ElectronicsText => new MyWebElement(By.XPath(ELECTRONICS_TEXT));
        public MyWebElement ComputerAndWeb => new MyWebElement(By.XPath(COMPUTER_AND_WEB));
        public MyWebElement LaptopsAndComputers => new MyWebElement(By.XPath(LAPTOPS_AND_COMPUTERS));
        public MyWebElement Laptops => new MyWebElement(By.XPath(LAPTOPS));

        public void NavigateToTvPage()
        {
            Electronics.Click();
            TvAndVideo.Click();
            Tv.Click();
        }

        public void NavigateToLaptopPage()
        {
            ComputerAndWeb.Click();
            LaptopsAndComputers.Click();
            Laptops.Click();
        }
    }
}
