using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Areas.Admin.Controllers;
using System.Web.Mvc;

namespace TestOnlineShop_Login
{
    /// <summary>
    /// Summary description for TestLoginControllerResultFake
    /// </summary>
    [TestClass]
    public class TestLoginControllerResultFake
    {
        [TestMethod] // pass
        public void TestPass()
        {
            LoginController login = new LoginController();
            RedirectToRouteResult result = login.LoginTestResultFake(1) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["Action"]);
            Assert.AreEqual("Home", result.RouteValues["Controller"]);
        }

        [TestMethod] //result = 0 sai username
        public void TesFail0()
        {
            LoginController login = new LoginController();
            var result = login.LoginTestResultFake(0) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["0"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -1 status = false
        public void TesFail1()
        {
            LoginController login = new LoginController();
            var result = login.LoginTestResultFake(-1) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-1"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -2 sai pass
        public void TesFail2()
        {
            LoginController login = new LoginController();
            var result = login.LoginTestResultFake(-2) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-2"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] // result = -3 không có quyền đăng nhập
        public void TesFail3()
        {
            LoginController login = new LoginController();
            var result = login.LoginTestResultFake(-3) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState["-3"]);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod] /// khong co result
        public void TesFail()
        {
            LoginController login = new LoginController();
            var result = login.LoginTestResultFake(-4) as ViewResult;
            Assert.IsNotNull(result.ViewData.ModelState[""]);
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
