using Microsoft.VisualStudio.TestTools.UnitTesting;
using Royalmind.Security;

namespace Royalmind.Security.UnitTest
{
    [TestClass]
    public class HashUtilsTest
    {
        [TestMethod]
        public void SHA1Test()
        {
            string computed = HashUtils.SHA1("abc123");

            Assert.AreEqual(computed, "6367c48dd193d56ea7b0baad25b19455e529f5ee");
        }

        [TestMethod]
        public void SHA256Test()
        {
            string computed = HashUtils.SHA256("abc123");

            Assert.AreEqual(computed, "6ca13d52ca70c883e0f0bb101e425a89e8624de51db2d2392593af6a84118090");
        }

        [TestMethod]
        public void SHA512Test()
        {
            string computed = HashUtils.SHA512("abc123");

            Assert.AreEqual(computed, "c70b5dd9ebfb6f51d09d4132b7170c9d20750a7852f00680f65658f0310e810056e6763c34c9a00b0e940076f54495c169fc2302cceb312039271c43469507dc");
        }

        [TestMethod]
        public void MD5Test()
        {
            string computed = HashUtils.MD5("abc123");

            Assert.AreEqual(computed, "e99a18c428cb38d5f260853678922e03");
        }
    }
}
