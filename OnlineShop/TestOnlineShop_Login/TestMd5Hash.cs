using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestOnlineShop_Login
{
   
    [TestClass]
    public class TestMd5Hash
    {
        [TestMethod]
        public void TestMd5()
        {
            string test = "123";
            string kq = "202cb962ac59075b964b07152d234b70";

            string result = OnlineShop.Common.Encryptor.MD5Hash(test);
            Assert.AreEqual(result, kq, " sai r");

        }

        [TestMethod]
        public void TestMd5Fail()
        {
            string test = "123";
            string kq = "202cb962ac59075b964b07152d234b70";

            string result = OnlineShop.Common.Encryptor.MD5Hash(test);
            Assert.AreEqual(result, kq, " sai r");

        }
    }
}
