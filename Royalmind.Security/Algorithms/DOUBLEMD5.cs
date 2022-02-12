namespace Royalmind.Security.Algorithms
{
    public class DOUBLEMD5
    {
        public static string CalculateHash(string text) => HashUtils.MD5(HashUtils.MD5(text));

        public static bool Compare(string text, string hash) => CalculateHash(text).Equals(hash, StringComparison.InvariantCultureIgnoreCase);
    }
}
