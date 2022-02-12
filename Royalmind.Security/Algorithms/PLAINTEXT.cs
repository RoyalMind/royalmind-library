namespace Royalmind.Security.Algorithms
{
    [Obsolete("No se recomienda en lo absoluto.")]
    public class PLAINTEXT
    {
        public static string CalculateHash(string text) => text;

        public static bool Compare(string text, string hash) => text.Equals(hash, StringComparison.InvariantCultureIgnoreCase);
    }
}
