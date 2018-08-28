using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechMarket.Models;

namespace TechMarket.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Products()
        {
            var phone = new Phone() { Name="Oneplus"};
            return View(phone);
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }

        public ActionResult Index(int?  pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}"));
        }
    }
}