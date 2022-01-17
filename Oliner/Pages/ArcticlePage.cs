using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class ArcticlePage
    {
        public const string SLIGHT_SMILE = "//div[@data-reaction='slight_smile']";
        public const string SLIGHT_SMILE_COUNT = "//div[@data-reaction='slight_smile']//span[contains(@class,'st-count')]";////div[@data-reaction='slight_smile']//span[@class='st-count']
        public const string SLIGHT_SMILE_SELECTED = "//div[contains(@class,'st-selected')]";

        public MyWebElement SlightSmile => new MyWebElement(By.XPath(SLIGHT_SMILE));
        public MyWebElement SlightSmileCount => new MyWebElement(By.XPath(SLIGHT_SMILE_COUNT));
        public MyWebElement SlightSmileSelected => new MyWebElement(By.XPath(SLIGHT_SMILE_SELECTED));

        public void ClickSlightSmile()
        {
            SlightSmile.Click();
        }

        public int GetSlightSmilesValues()
        {
            return int.Parse(SlightSmileCount.Text);
        }



    }
}
