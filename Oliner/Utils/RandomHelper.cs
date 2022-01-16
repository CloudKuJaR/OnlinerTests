using System;

namespace Onliner.Utils
{
    // Нужен ли???
    public class RandomHelper
    {
        public string GetRandomString()
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
    }
}
