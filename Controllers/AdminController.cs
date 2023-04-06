using MyOnlineShop.DAL;
using MyOnlineShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOnlineShop.Controllers
{
    public class AdminController : Controller
    {
        public GenericUnitOfWork _unitofwork = new GenericUnitOfWork();
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Categories()
        {
            List<Tbl_Category> tbl_Categories= _unitofwork.GetRepositoryInstance<Tbl_Category>().GetAllRecordsIQueryable().Where(i=>i.IsDelete==false).ToList();
            return View(tbl_Categories);
        }
    }
}