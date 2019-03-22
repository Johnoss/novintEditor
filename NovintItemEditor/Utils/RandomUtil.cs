using System;
using System.Linq;

namespace NovintItemEditor.Utils
{
    public static class RandomUtil
    {
        private const int RandomStringLength = 10;
        private static readonly Random _random = new Random();
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, RandomStringLength)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
