namespace Royalmind.Security.Algorithms
{
    public class SHA512
    {
        public static string CalculateHash(string text) => HashUtils.SHA512(text);

        public static bool Compare(string text, string hash)
            => CalculateHash(text).Equals(hash, StringComparison.InvariantCultureIgnoreCase);

    }
}
