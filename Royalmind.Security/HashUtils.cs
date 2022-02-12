using System;
using System.Security.Cryptography;
using System.Text;

namespace Royalmind.Security
{
    public class HashUtils
    {
        public static string SHA1(string text) => Hash(text, System.Security.Cryptography.SHA1.Create(), Encoding.UTF8);
        public static string SHA256(string text) => Hash(text, System.Security.Cryptography.SHA256.Create(), Encoding.UTF8);
        public static string SHA512(string text) => Hash(text, System.Security.Cryptography.SHA512.Create(), Encoding.UTF8);
        public static string MD5(string text) => Hash(text, System.Security.Cryptography.MD5.Create(), Encoding.UTF8);

        public static string Hash(string text, HashAlgorithm hashAlgorithm, Encoding encoding)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(text));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();

        }
    }
}
