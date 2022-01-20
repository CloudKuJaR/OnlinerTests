using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ArcticlePage
    {
        private const string SLIGHT_SMILE = "//div[@data-reaction='slight_smile']";
        private const string SLIGHT_SMILE_COUNT = "//div[@data-reaction='slight_smile']//span[contains(@class,'st-count')]";////div[@data-reaction='slight_smile']//span[@class='st-count']
        private const string SLIGHT_SMILE_SELECTED = "//div[contains(@class,'st-selected')]";

        private MyWebElement SlightSmileSelected => new MyWebElement(By.XPath(SLIGHT_SMILE_SELECTED));
        private MyWebElement SlightSmile => new MyWebElement(By.XPath(SLIGHT_SMILE));
        private MyWebElement SlightSmileCount => new MyWebElement(By.XPath(SLIGHT_SMILE_COUNT));

        public void ClickSlightSmile() => SlightSmile.Click();

        public int GetSlightSmilesValues() => int.Parse(SlightSmileCount.Text);

        public bool IsSlightSmileSelectedPresent() => SlightSmileSelected.IsPresent();
    }
}
