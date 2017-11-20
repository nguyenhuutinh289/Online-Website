using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Areas.Admin.Controllers;
using Models.EF;
using System.Web.Mvc;

namespace TestOnlineShop_Login
{
    
    [TestClass]
    public class TestLoginControllerFull
    {
        public TestLoginControllerFull()
        { }

        [TestMethod]
        public void TestPass()
        {
            LoginController login = new LoginController();

            User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "ADMIN", true);
            User loginUser = new User("admin", "123", "ADMIN", true);

            RedirectToRouteResult result = login.LoginTest(admin, loginUser) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["Action"]);
            Assert.AreEqual("Home", result.RouteValues["Controller"]);
        }

        [TestMethod] //result = 0 sai username
        public void TesFail0()
        {
            LoginController login = new LoginController();

            User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "ADMIN", true);
            User loginUser = new User("admin1", "123", "ADMIN", true);

            var result = login.LoginTest(admin, loginUser) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["0"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -1 status = false
        public void TesFail1()
        {
            LoginController login = new LoginController();

            User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "ADMIN", false);
            User loginUser = new User("admin", "123");

            var result = login.LoginTest(admin, loginUser) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-1"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -2 sai pass
        public void TesFail2()
        {
            LoginController login = new LoginController();

            User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "ADMIN", true);
            User loginUser = new User("admin", "1231");

            var result = login.LoginTest(admin, loginUser) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-2"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -3 không có quyền đăng nhập
        public void TesFail3()
        {
            LoginController login = new LoginController();
            User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "MEMBER", true);
            User loginUser = new User("admin", "123");

            var result = login.LoginTest(admin, loginUser) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-3"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        //[TestMethod] /// khong co result
        //public void TesFail()
        //{
        //    LoginController login = new LoginController();
        //    User admin = new User("admin", "202cb962ac59075b964b07152d234b70", "ADMIN", true);
        //    User loginUser = new User("admin", "123");

        //    var result = login.LoginTest(admin, loginUser) as ViewResult;
        //    Assert.IsNotNull(result.ViewData.ModelState[""]);
        //    Assert.AreEqual("Index", result.ViewName);
        //}

    }
}
