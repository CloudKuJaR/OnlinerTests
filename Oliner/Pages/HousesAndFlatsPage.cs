using Onliner.WebDriverExtension;
using Onliner.WebElementExtension;
using OpenQA.Selenium;
using System.Linq;

namespace Onliner.Pages
{
    public class HousesAndFlatsPage
    {
        private const string RENT_BUTTON = "//a[@href='https://r.onliner.by/ak/']";
        private const string CITY_AND_ADDRESS_DROP_DOWN_MENU = "//div[@class='filter__item filter__item_left filter__item_search']";
        private const string REGIONAL_CITIES_NAMES_IN_DROP_DOWN_MENU = "//ul[@class='dropdown__menu dropdown__menu_wide']//li[text()='{0}']";
        private const string FILTER_FLAT_BUTTON = "//label[@class='filter__item filter__item_50']//span[@class='filter__item-inner']";
        private const string FILTER_NUMBER_OF_ROOMS = "//label[@class='filter__item filter__item_25']//span[text()='{0}']";
        private const string FILTER_PRICE_TO_FIELD = "//input[@id='search-filter-price-to']";
        private const string SUBWAY_DROP_DOWN_MENU = "//div[@class='dropdown dropdown_2 dropdown_no-arrow']";
        private const string SUBWAY_DROP_DOWN_MENU_OPTION = "//ul[@class='dropdown__menu dropdown__menu_extended dropdown__menu_with-tip']//li[contains(text(),'{0}')]";
        private const string FILTER_SORT_BY_DROP_DOWN_MENU = "//div[@class='dropdown dropdown_right']";
        private const string SORT_BY_DROP_DOWN_MENU_OPTION = "//ul[@class='dropdown__menu dropdown__menu_with-tip']//li[contains(text(),'{0}')]";
        private const string MAP = "//div[@id='map']";
        private const string FLAT_CONTAINER = "//div[@class='classifieds-list']";
        private const string QUANTITY_OF_FLATS_CONTAINER = "//div[@class='classifieds-bar__item']";
        private const string STREET_NAME_OF_THE_FIRST_FLAT = "(//span[@class='classified__caption-item classified__caption-item_adress'])[1]";

        private MyWebElement Map => new MyWebElement(By.XPath(MAP));
        private MyWebElement RentButton => new MyWebElement(By.XPath(RENT_BUTTON));
        private MyWebElement CityAndAddressDropDownMenu => new MyWebElement(By.XPath(CITY_AND_ADDRESS_DROP_DOWN_MENU));
        private MyWebElement FilterFlatButton => new MyWebElement(By.XPath(FILTER_FLAT_BUTTON));
        private MyWebElement FilterPriceToField => new MyWebElement(By.XPath(FILTER_PRICE_TO_FIELD));
        private MyWebElement SubWayDropDownMenu => new MyWebElement(By.XPath(SUBWAY_DROP_DOWN_MENU));
        private MyWebElement FilterSortByDropDownMenu => new MyWebElement(By.XPath(FILTER_SORT_BY_DROP_DOWN_MENU));
        private MyWebElement FlatContainer => new MyWebElement(By.XPath(FLAT_CONTAINER));
        private MyWebElement QuantityOfFlatsContainer => new MyWebElement(By.XPath(QUANTITY_OF_FLATS_CONTAINER));
        private MyWebElement StreetNameOfTheFirstFlat => new MyWebElement(By.XPath(STREET_NAME_OF_THE_FIRST_FLAT));

        public void ClickRentButton() => RentButton.Click();

        public void ChooseCity(string cityName) => new MyWebElement(By.XPath(string.Format(REGIONAL_CITIES_NAMES_IN_DROP_DOWN_MENU, cityName))).Click();

        public void ClickFilterFlatButton() => FilterFlatButton.Click();

        public void ChooseNumberOfRooms(string numberOfRooms) => new MyWebElement(By.XPath(string.Format(FILTER_NUMBER_OF_ROOMS, numberOfRooms))).Click();

        public void ClickSubWayDropDownMenu() => SubWayDropDownMenu.Click();

        public void ChooseSubWayDropDownMenuOption(string optionName) => new MyWebElement(By.XPath(string.Format(SUBWAY_DROP_DOWN_MENU_OPTION, optionName))).Click();

        public void ClickFilterSortByDropDownMenu() => FilterSortByDropDownMenu.Click();

        public void ChooseFilterSortByDropDownMenuOption(string optionName) => new MyWebElement(By.XPath(string.Format(SORT_BY_DROP_DOWN_MENU_OPTION, optionName))).Click();

        public string GetPageTitle() => Driver.driver.Title;

        public void WaitForQuantityOfFlatsChanged(int quantity) => Driver.driver.GetWait().Until(drv => int.Parse(string.Join("", QuantityOfFlatsContainer.Text.Where(c => char.IsDigit(c)))) != quantity);

        public bool IsMapPresent() => Map.IsPresent();

        public string GetStreetNameOfTheFirstFlat()
        {
            StreetNameOfTheFirstFlat.WaitForElementIsDisplayed();
            return StreetNameOfTheFirstFlat.Text;
        }

        public int GetQuantityOfFlats()
        {
            QuantityOfFlatsContainer.WaitForElementIsDisplayed();
            string flatsQuantityString = QuantityOfFlatsContainer.Text;
            int quantityOfFlatsValue = int.Parse(string.Join("", flatsQuantityString.Where(c => char.IsDigit(c))));
            return quantityOfFlatsValue;
        }

        public void FillFilterPriceToField(string flatPriceTo)
        {
            FilterPriceToField.Click();
            FilterPriceToField.SendKeys(flatPriceTo + Keys.Enter);
        }

        public void ClickCityAndAddressDropDownMenu()
        {
            CityAndAddressDropDownMenu.HoverOver();
            CityAndAddressDropDownMenu.Click();
        }

        public bool IsFlatContainsOnlyNumberOfRooms()
        {
            bool isFlatContains = true;
            Driver.driver.GetWait().Until(drv => FlatContainer.FindElements(By.XPath(".//span[@class='classified__caption']//span[1]")).Count != 0);
            var NumberOfRoomContainer = FlatContainer.FindElements(By.XPath(".//span[@class='classified__caption']//span[1]"));
            foreach (var item in NumberOfRoomContainer)
            {
                if (item.Text.Contains("Комната"))
                {
                    isFlatContains = false;
                    break;
                }
            }

            return isFlatContains;
        }

        public bool IsFlatContainsOnlyTwoRoomsFlat()
        {
            bool isFlatContains = true;
            Driver.driver.GetWait().Until(drv => FlatContainer.FindElements(By.XPath(".//span[@class='classified__caption']//span[1]")).Count != 0);
            var NumberOfRoomContainer = FlatContainer.FindElements(By.XPath(".//span[@class='classified__caption']//span[1]"));
            foreach (var item in NumberOfRoomContainer)
            {
                if (!item.Text.Contains("2к"))
                {
                    isFlatContains = false;
                    break;
                }
            }

            return isFlatContains;
        }

        // <FIX> Подфиксай имя метода, не оч красиво звучит. Например LessThanPrevious
        public bool IsFlatContainsPriceLessThan()
        {
            bool isFlatContains = true;
            Driver.driver.GetWait().Until(drv => FlatContainer.FindElements(By.XPath(".//span[@class='classified__price-value classified__price-value_complementary']//span[1]")).Count != 0);
            var NumberOfRoomContainer = FlatContainer.FindElements(By.XPath(".//span[@class='classified__price-value classified__price-value_complementary']//span[1]"));
            foreach (var item in NumberOfRoomContainer)
            {
                int priceValue = int.Parse(item.Text);
                if (priceValue > 500)
                {
                    isFlatContains = false;
                    break;
                }
            }

            return isFlatContains;
        }
    }
}
