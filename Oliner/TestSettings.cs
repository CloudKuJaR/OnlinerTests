using Microsoft.Extensions.Configuration;

namespace Onliner
{
    public static class TestSettings
    {
        static TestSettings()
        {
            SetDefaultValues();
        }

        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string SearchItem { get; set; }

        private static void SetDefaultValues()
        {
            UserName = TestConfiguration["UserName"];
            Password = TestConfiguration["Password"];
            SearchItem = TestConfiguration["SearchItem"];
        }
    }
}
