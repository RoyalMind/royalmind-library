namespace Royalmind.Security.Algorithms
{
    public class SHA256
    {
        public static ushort SALT_LENGTH { get => 16; }

        public static string ComputeHash(string text, string salt)
            => $"$SHA${salt}${HashUtils.SHA256(HashUtils.SHA256(text) + salt)}";

        public static bool Compare(string text, string salt, string hash)
            => ComputeHash(text, salt).Equals(hash, StringComparison.InvariantCultureIgnoreCase);
    }
}
