using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Areas.Admin.Controllers;
using Models.EF;
using System.Web.Mvc;

namespace TestOnlineShop_Login
{
    /// <summary>
    /// Summary description for TestUserController
    /// </summary>
    [TestClass]
    public class TestUserController
    {
        [TestMethod]
        public void TestusernameNULL()
        {
            UserController controller = new UserController();

            User user = new User(null, null);

            var result = controller.Create(user) as ViewResult;

            Assert.AreEqual("Create", result.ViewName);
        }

        [TestMethod]
        public void TestPassNULL()
        {
            UserController controller = new UserController();

            User user = new User("admin1", null);

            var result = controller.Create(user) as ViewResult;

            Assert.AreEqual("Create", result.ViewName);
        }

        [TestMethod]
        public void Testpass()
        {
            UserController controller = new UserController();

            User user = new User("admin", "123");
            RedirectToRouteResult result = controller.CreateTest(user) as RedirectToRouteResult;

            Assert.AreEqual("Select", result.RouteValues["Action"]);
            Assert.AreEqual("User", result.RouteValues["Controller"]);
        }

        [TestMethod]
        public void Testpass1()
        {
            UserController controller = new UserController();
            User user = new User("admin", "123");
            var result = controller.CreateTest(user) as ViewResult;
            Assert.AreEqual("Create", result.ViewName);
        }
    }
}
