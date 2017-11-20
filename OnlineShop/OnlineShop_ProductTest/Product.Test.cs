using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop;
using Models;
using Models.DAO;
using Models.EF;
using OnlineShop.Common;
using Common;
using OnlineShop.Areas.Admin.Controllers;
namespace OnlineShopUnitTest
{
    [TestClass]
    public class ProductTest
    {
        private ProductDao pDAO;
        private Product p;
        private OnlineShop.Areas.Admin.Controllers.ProductController pController;

        [TestInitialize]
        public void SetUp()
        {
            this.pDAO = new ProductDao();
            this.p = new Product();
            this.pController = new OnlineShop.Areas.Admin.Controllers.ProductController();
        }

        [TestMethod]
        public void ViewProduct()
        {
            ProductController product = new ProductController();
            ViewResult result = product.Index() as ViewResult;
            Assert.IsNotNull(result);

        }

        /// <summary>
        /// Test Create DAO
        /// </summary>
        [TestMethod]
        public void TestCreateProductDAO()
        {            
            p.Name = "TestDAO";           
            p.Price = 11000000;
            p.Quantity = 1;
            long IdDuKien = 31;
            var result = pDAO.Insert(p);
            // tra ve Id sản phẩm ,Id là tự tăng 
            Assert.AreEqual<long>(IdDuKien, result);
        }

        /// <summary>
        /// Test Delete DAO
        /// </summary>
        [TestMethod]
        public void TestDeleteProductDAO()
        {
            int Id = 31;
            Assert.AreEqual<bool>(true, pDAO.Delete(Id));
        }

        /// <summary>
        /// Test Update DAO
        /// </summary>
        [TestMethod]
        public void TestUpdateProductDAO()
        {
            p.ID = 33; 
            p.Name = "UpdateTestDAO";                                 
            p.Quantity = 2;
            p.Price = 22000000;
            Assert.AreEqual<bool>(true, pDAO.Update(p));
        }

        /// <summary>
        /// Test Create Controller
        /// </summary>
        [TestMethod]
        public void TestCreateProductController()
        {
            p.Name = "TestController" ;
            //p.Name = null;           
            p.Price = 11000000;
            p.Quantity = 1;                  
            var result = pController.Create(p) as RedirectToRouteResult;
            Assert.AreEqual("Create", result.RouteValues["action"]);           
        }
        /// <summary>
        /// Test Delete Controller
        /// </summary>
        [TestMethod]
        public void TestDeleteProductController()
        {
            int id = 35;
            var result = pController.Delete(id) as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        /// <summary>
        /// Test Update Controller
        /// </summary>
        [TestMethod]
        public void TestUpdateProductController()
        {
            p.ID = 36;          
            p.Name = "UpdateTestControler";
            p.Quantity = 2;
            p.Price = 22000000;
            var result = pController.Edit(p) as RedirectToRouteResult;
            Assert.AreEqual("Select", result.RouteValues["action"]);
        }

        //[TestMethod]
        //public void TestSelectAndSearchController()
        //{
        //    //string searchStr = "Laptop Asus";
        //    string searchStr = null;
        //    ViewResult result = pController.Select(searchStr, 1, 5) as ViewResult;
        //    Assert.AreEqual("Select", result.ViewName);       

        //}

    }
}
