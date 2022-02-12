namespace Royalmind.Security
{
    public class PasswordSecurity
    {
        public class Result
        {
            public string? Hash { get; set; }
            public string? Salt { get; set; }
        }

        public static string Compute(string text, EncryptionType type)
        {
            string result;

            switch (type)
            {
                case EncryptionType.PLAINTEXT:
                    result = text;
                    break;
                case EncryptionType.MD5:
                    result = Algorithms.MD5.CalculateHash(text);
                    break;
                case EncryptionType.DOUBLEMD5:
                    result = Algorithms.DOUBLEMD5.CalculateHash(text);
                    break;
                case EncryptionType.SHA1:
                    result = Algorithms.SHA1.CalculateHash(text);
                    break;
                case EncryptionType.SHA512:
                    result = Algorithms.SHA512.CalculateHash(text);
                    break;
                default:
                    throw new ArgumentException("No se puede generar el hash sin sal.");
            }

            return result;
        }

        public static string Compute(string text, string salt, EncryptionType type)
        {
            string result;

            switch (type)
            {
                case EncryptionType.SHA256:
                    result = Algorithms.SHA256.ComputeHash(text, salt);
                    break;
                case EncryptionType.SALTEDSHA512:
                    result = Algorithms.SALTEDSHA512.ComputeHash(text, salt);
                    break;
                default:
                    throw new ArgumentException("No se puede aplicar la sal a ese algoritmo.");
            }

            return result;
        }

        public static bool Verify(string text, string hash, EncryptionType type, string salt = null)
        {
            bool result = false;

            switch (type)
            {
                case EncryptionType.PLAINTEXT:
                    result = text.Equals(hash, StringComparison.InvariantCultureIgnoreCase);
                    break;
                case EncryptionType.MD5:
                    result = Algorithms.MD5.Compare(text, hash);
                    break;
                case EncryptionType.DOUBLEMD5:
                    result = Algorithms.DOUBLEMD5.Compare(text, hash);
                    break;
                case EncryptionType.SHA1:
                    result = Algorithms.SHA1.Compare(text, hash);
                    break;
                case EncryptionType.SHA256:
                    result = Algorithms.SHA256.Compare(text, salt, hash);
                    break;
                case EncryptionType.SHA512:
                    result = Algorithms.SHA512.Compare(text, hash);
                    break;
                case EncryptionType.SALTEDSHA512:
                    result = Algorithms.SALTEDSHA512.Compare(text, salt, hash);
                    break;
            }

            return result;
        }
    }
}
