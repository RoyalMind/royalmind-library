using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royalmind.Security.Algorithms
{
    public class SHA1
    {
        public static string CalculateHash(string text)
            => HashUtils.SHA1(text);

        public static bool Compare(string text, string hash)
            => CalculateHash(text).Equals(hash, StringComparison.InvariantCultureIgnoreCase);
    }
}
