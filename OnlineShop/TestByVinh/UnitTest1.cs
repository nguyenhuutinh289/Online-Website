using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models.EF;
using OnlineShop.Areas.Admin.Controllers;
using System.Web.Mvc;

namespace TestByVinh
{
    [TestClass]
    public class UnitTest1
    {
        #region Category


        [TestMethod]
        public void TestInsertView()
        {
            var test = CategoryTest();

            var controller = new CategoryController();
            var result = controller.Create(test) as RedirectToRouteResult;
            
            Assert.AreEqual("Create", result.RouteValues["action"]);
        }

        [TestMethod]
        public void TestSelectStringCategory()
        {
            var controller = new CategoryController();
            var result = controller.Select("laptop", 1, 5) as ViewResult;

            //Assert.AreEqual("laptop", result.ViewBag);
            //Assert.AreEqual("laptop", result.ViewData["SearchString"]);
            Assert.AreEqual("laptop", result.ViewBag.SearchString);
        }

        private Category CategoryTest()
        {
            var testCategory = new Category();
            testCategory.Name = "";
            testCategory.MetaTitle = "1";
            testCategory.DisplayOrder = 3;
            testCategory.Status = true;
            testCategory.ShowOnHome = true;
            return testCategory;
        }
        #endregion

        #region User


        private User UserTest()
        {
            var testUser = new User();
            testUser.Name = "Thanh vien 1";
            testUser.Password = "123";
            testUser.UserName = "TV1";
            //testUser.GroupID = "MEMBER";
            return testUser;
        }

        [TestMethod]
        public void TestInsertUser()
        {
            var user = UserTest();

            var controller = new UserController();
            var result = controller.Create(user) as RedirectToRouteResult;

            Assert.AreEqual("Select", result.RouteValues["action"]);
            Assert.AreEqual("User", result.RouteValues["controller"]);
        }

        [TestMethod]
        public void TestEditUser()
        {
            var user = UserTest();

            var controller = new UserController();
            var result = controller.Edit(user) as RedirectToRouteResult;

            Assert.AreEqual("Select", result.RouteValues["action"]);
            Assert.AreEqual("User", result.RouteValues["controller"]);
        }

        [TestMethod]
        public void TestDeleteUser()
        {
            var user = UserTest();

            var controller = new UserController();
            var result = controller.Delete(1) as RedirectToRouteResult;

            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        #endregion
    }
} 
