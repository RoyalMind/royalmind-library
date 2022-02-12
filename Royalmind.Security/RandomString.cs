using System.Text;

namespace Royalmind.Security
{
    public class RandomString
    {
        private static readonly string CHARS = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random RANDOM = new Random();
        private static readonly int HEX_MAX_INDEX = 16;
        private static readonly int LOWER_ALPHANUMERIC_INDEX = 36;

        public static string Generate(int n) => Generate(n, LOWER_ALPHANUMERIC_INDEX);

        public static string GenerateHex(int n) => Generate(n, HEX_MAX_INDEX);

        public static string GenerateLowerUpper(int n) => Generate(n, CHARS.Length);

        private static string Generate(int n, int n2)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Length must be positive but was {n}.");

            StringBuilder sb = new StringBuilder(n);

            for (int i = 0; i < n; ++i) { sb.Append(CHARS.ElementAt(RandomString.RANDOM.Next(n2))); }

            return sb.ToString();
        }
    }
}