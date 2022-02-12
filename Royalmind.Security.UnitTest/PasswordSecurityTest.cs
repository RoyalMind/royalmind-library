using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Royalmind.Security.UnitTest
{
    [TestClass]
    public class PasswordSecurityTest
    {
        [TestMethod]
        public void MD5ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", EncryptionType.MD5);

            Assert.AreEqual(result, "e99a18c428cb38d5f260853678922e03");
        }

        [TestMethod]
        public void DOUBLEMD5ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", EncryptionType.DOUBLEMD5);

            Assert.AreEqual(result, "57f231b1ec41dc6641270cb09a56f897");
        }

        [TestMethod]
        public void SHA1ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", EncryptionType.SHA1);

            Assert.AreEqual(result, "6367c48dd193d56ea7b0baad25b19455e529f5ee");
        }

        [TestMethod]
        public void SHA512ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", EncryptionType.SHA512);

            Assert.AreEqual(result, "c70b5dd9ebfb6f51d09d4132b7170c9d20750a7852f00680f65658f0310e810056e6763c34c9a00b0e940076f54495c169fc2302cceb312039271c43469507dc");
        }

        [TestMethod]
        public void SHA256ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", "XYZ", EncryptionType.SHA256);

            Assert.AreEqual(result, "$SHA$XYZ$ab098c4d2e21c2c16fb7ecafc3d45858eebd9174352580c283f7390fb389d31f");
        }

        [TestMethod]
        public void SALTEDSHA512ComputeTest()
        {
            string result = PasswordSecurity.Compute("abc123", "XYZ", EncryptionType.SALTEDSHA512);

            Assert.AreEqual(result, "0c3f7f128346ecfb856652f971cce40f12341c65269a7a4979db1fb3360c908d954cfca20bc45dab17ba1c5e4897f7ea1a8dad4817265dcb335436c613d11026");
        }
    }
}
