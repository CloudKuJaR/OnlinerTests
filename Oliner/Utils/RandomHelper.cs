using System;

namespace Onliner.Utils
{
    public static class RandomHelper
    {
        public static string GetRandomString()
        {
            char[] letters = "qwertyuiopasdfghzxcvb".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 4; i++)
            {
                randomString += letters[r.Next(0, 21)].ToString();
            }
            return randomString;
        }

        public static int GetRandomValue()
        {
            Random r = new Random();
            int randomValue = r.Next(10,1000);
            return randomValue;
        }
    }
}
