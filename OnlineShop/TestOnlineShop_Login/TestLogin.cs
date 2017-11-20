using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.DAO;
using Models.EF;

namespace TestOnlineShop_Login
{
    
    [TestClass]
    public class TestLogin
    {
        [TestMethod] // tất cả thông tin hợp lệ return 1
        public void TestDangNhapThanhCong()
        {
            UserDao dao = new UserDao();
            User Test = new User("admin", "123", "ADMIN", true);

            int KqLogin = dao.Login(Test, "admin", "123");

            Assert.AreEqual(KqLogin, 1);
        }

        [TestMethod] // sai username return 0
        public void TestFailUserName()
        {
            UserDao dao = new UserDao();
            User Test = new User("admin", "123", "ADMIN", true);

            int KqLogin = dao.Login(Test, "admin1", "123");
            Assert.AreEqual(KqLogin, 0);
        }


        [TestMethod] // user không có quyền đăng nhập return -3
        public void TestFailGroupID()
        {
            UserDao dao = new UserDao();
            User Test = new User("admin", "123", "Mod", true);

            int KqLogin = dao.Login(Test, "admin", "123");
            Assert.AreEqual(KqLogin, -3);
        }

        [TestMethod] // status = false return -1
        public void TestFailStatus()
        {
            UserDao dao = new UserDao();
            User Test = new User("admin", "123", "ADMIN", false);

            int KqLogin = dao.Login(Test, "admin", "123");
            Assert.AreEqual(KqLogin, -1);
        }

        [TestMethod] // sai pass return -2
        public void TestFailPassWord()
        {
            UserDao dao = new UserDao();
            User Test = new User("admin", "123", "ADMIN", true);

            int KqLogin = dao.Login(Test, "admin", "456");
            Assert.AreEqual(KqLogin, -2);
        }


        [TestMethod] // tất cả thông tin hợp lệ return 1
        public void TestDangNhapThanhCong1()
        {
            UserDao dao = new UserDao();
            string test = "123";
            string password = "202cb962ac59075b964b07152d234b70";
            User Test = new User("admin", password, "ADMIN", true);

            string result = OnlineShop.Common.Encryptor.MD5Hash(test);
            int KqLogin = dao.Login(Test, "admin", result);
            Assert.AreEqual(KqLogin, 1);
        }
    }
}
