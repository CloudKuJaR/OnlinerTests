namespace Onliner
{
    public static class Config
    {
        public static string baseUrl = "https://www.onliner.by/";

        public static class Credentials
        {
            public static string userMail = "taram99815@patmui.com";
            public static string userPassword = "casm9hir8LOT@klap";
        }

        public static class SearchInformation
        {
            public static string searchItem = "Thinkpad T14";
        }

        public static class Locators
        {
            public static string product1 = "//span[text()='Телевизор Samsung QE50LS01TAU']/..";
            public static string product2 = "//span[text()='Телевизор LG 55NANO926PB']/..";
        }
    }
}
