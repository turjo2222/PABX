using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PabxInfo.BLL.BLL;
using PabxInfo.Models;
using PabxInfo.Models.Models;
using System.Web.Mvc;

namespace PabxInfo.Controllers
{
    public class DesignationController : Controller
    {
        DesignationManager _designationManager = new DesignationManager();
        private Designation _designation = new Designation();
        // GET: Designation
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // Post: Designation
        [HttpPost]
        public ActionResult Index(Designation designation)
        {
            if (ModelState.IsValid)
                if (_designationManager.Add(designation))
                {
                    ViewBag.SuccessMsg = "Add designation";
                    // return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.FailMsg = "designation ADD Failed";
                }

            else
            {
                ViewBag.FailMsg = "Validation Error";
            }

            return View();


        }
    }
}