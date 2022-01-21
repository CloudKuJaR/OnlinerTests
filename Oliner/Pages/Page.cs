using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Driver.driver, page);
            return page;
        }

        // <FIX> Use this style here:
        // public static SomePage SomePage => GetPage<SomePage>();

        public static CartPage CartPage
        {
            get { return GetPage<CartPage>(); }
        }

        public static CatalogPage CatalogPage
        {
            get { return GetPage<CatalogPage>(); }
        }

        public static LoginForm LoginPage
        {
            get { return GetPage<LoginForm>(); }
        }

        public static Menu Menu
        {
            get { return GetPage<Menu>(); }
        }

        public static ProductPage ProductPage
        {
            get { return GetPage<ProductPage>(); }
        }

        public static OrderPage OrderPage
        {
            get { return GetPage<OrderPage>(); }
        }

        public static ComparePage ComparePage
        {
            get { return GetPage<ComparePage>(); }
        }

        public static LaptopsPage LaptopsPage
        {
            get { return GetPage<LaptopsPage>(); }
        }

        public static ProductsCatalogPage ProductsCatalogPage
        {
            get { return GetPage<ProductsCatalogPage>(); }
        }

        public static RegistrationPage RegistrationPage
        {
            get { return GetPage<RegistrationPage>(); }
        }

        public static HomePage HomePage
        {
            get { return GetPage<HomePage>(); }
        }

        public static ArcticlePage ArcticlePage
        {
            get { return GetPage<ArcticlePage>(); }
        }

        public static UserSupportPage UserSupportPage
        {
            get { return GetPage<UserSupportPage>(); }
        }

        public static CurrencyConversionPage CurrencyConversionPage
        {
            get { return GetPage<CurrencyConversionPage>(); }
        }

        public static HousesAndFlatsPage HousesAndFlatsPage
        {
            get { return GetPage<HousesAndFlatsPage>(); }
        }
    }
}
