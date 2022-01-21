using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class CatalogPage
    {

        private const string TV_PAGE = "//a[@href='https://catalog.onliner.by/tv']";
        private const string ELECTRONICS_SECTION = "//li[@data-id='1']";
        private const string TV_AND_VIDEO_SECTION = "//a[@href='https://catalog.onliner.by/tv']/../../..";
        private const string ELECTRONICS_TEXT = "//span[text()='Электроника']";
        private const string COMPUTER_AND_WEB_SECTION = "//li[@data-id='2']";
        private const string LAPTOPS_AND_COMPUTERS_SECTION = "//div[text()=' Ноутбуки, компьютеры, мониторы ']";
        private const string LAPTOPS_PAGE = "//a[@href='https://catalog.onliner.by/notebook']";

        private MyWebElement ElectronicsText => new MyWebElement(By.XPath(ELECTRONICS_TEXT));
        private MyWebElement TvPage => new MyWebElement(By.XPath(TV_PAGE));
        private MyWebElement ElectronicsSection => new MyWebElement(By.XPath(ELECTRONICS_SECTION));
        private MyWebElement TvAndVideoSection => new MyWebElement(By.XPath(TV_AND_VIDEO_SECTION));
        private MyWebElement ComputerAndWebSection => new MyWebElement(By.XPath(COMPUTER_AND_WEB_SECTION));
        private MyWebElement LaptopsAndComputersSection => new MyWebElement(By.XPath(LAPTOPS_AND_COMPUTERS_SECTION));
        private MyWebElement LaptopsPage => new MyWebElement(By.XPath(LAPTOPS_PAGE));

        public string GetElectronicsText() => ElectronicsText.Text;

        public void NavigateToTvPage()
        {
            ElectronicsSection.Click();
            TvAndVideoSection.Click();
            TvPage.Click();
        }

        public void NavigateToLaptopPage()
        {
            ComputerAndWebSection.Click();
            LaptopsAndComputersSection.Click();
            LaptopsPage.Click();
        }
    }
}
