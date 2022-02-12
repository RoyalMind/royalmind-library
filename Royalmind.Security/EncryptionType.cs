using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royalmind.Security
{
    public enum EncryptionType
    {
        PLAINTEXT,
        MD5,
        DOUBLEMD5,
        SHA1,
        SHA256,
        SHA512,
        SALTEDSHA512,
    }
}
