namespace Royalmind.Security.Algorithms
{
    public class SALTEDSHA512
    {
        public static string ComputeHash(string text, string salt) 
            => HashUtils.SHA512(HashUtils.SHA512(text) + salt);
        public static bool Compare(string text, string salt, string hash)
            => ComputeHash(text, salt).Equals(hash, StringComparison.InvariantCultureIgnoreCase);
    }
}
