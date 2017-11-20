using Models.DAO;
using Models.EF;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        public object StaticResources { get; private set; }

        //
        // GET: /Admin/Category/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Select(string searchString, int page = 1, int pageSize = 5)
        {
            var dao = new CategoryDao();
            var model = dao.ListAllPaging(searchString, page, pageSize);
            //ViewData["SearchString"] = searchString;
            ViewBag.SearchString = searchString;
            return View(model);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category model)
        {
            if(model.Name == null)
            {
                SetAlert("Tên loại sản phẩm bắt buộc", "error");
                return View(model);
            }
            if (ModelState.IsValid)
            {
                //var currentCulture = Session[CommonConstants.CurrentCulture];
                //    model.Language = currentCulture.ToString();
                //var session = (Common.UserLogin)Session[OnlineShop.Common.CommonConstants.USER_SESSION];
                //model.CreatedBy = session.UserName;
                model.CreatedDate = DateTime.Now;
                var id = new CategoryDao().Insert(model);
                if (id > 0)
                {
                    SetAlert("Thêm loại sản phẩm thành công", "success");
                    return RedirectToAction("Create");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm loại sản phẩm không thành công");
                }
            }
            return View(model);
        }

    }
}
