using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PabxInfo.BLL.BLL;
using PabxInfo.Models;
using PabxInfo.Models.Models;
using System.Web.Mvc;
using AutoMapper;

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

        [HttpGet]
        public ActionResult Show()
        {
            DesignationAddViewModel designationVm = new DesignationAddViewModel();
            designationVm.Designations = _designationManager.GetAll();

            return View(designationVm);
        }

        public ActionResult Show(DesignationAddViewModel designationVm)
        {

            var designations = _designationManager.GetAll();

            if (designationVm.DesignationName != null)
            {
                designations = designations.Where(c => c.DesignationName.ToLower().Contains(designationVm.DesignationName.ToLower())).ToList();
            }


            designationVm.Designations = designations;

            return View(designationVm);

        }


        [HttpGet]
        public ActionResult Delete(int Id)
        {
            DesignationAddViewModel designationVm = new DesignationAddViewModel();
            Designation designation = new Designation();

            designation = _designationManager.GetById(Id);

            designationVm = Mapper.Map<DesignationAddViewModel>(designation);

            return View(designationVm);
        }


        [HttpPost]
        public ActionResult Delete(DesignationAddViewModel designationVm)
        {


            if (ModelState.IsValid)
            {
                var category = Mapper.Map<Designation>(designationVm);

                if (_designationManager.Delete(category))
                {
                    ViewBag.SuccessMsg = "Deleted!";
                }
                else
                {
                    ViewBag.ErrorMsg = "Failed!";
                }
            }
            else
            {
                ViewBag.ErrorMsg = "Validation!";
            }


            return RedirectToAction("Show", "Category");

        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Designation designation = new Designation();
            designation.ID = Id;
            designation = _designationManager.GetById(Id);

            DesignationAddViewModel categoryVm = new DesignationAddViewModel();
            categoryVm = Mapper.Map<DesignationAddViewModel>(designation);

            return View(categoryVm);

        }
        [HttpPost]
        public ActionResult Edit(DesignationAddViewModel designationVm)
        {
            if (ModelState.IsValid)
            {
                var category = Mapper.Map<Designation>(designationVm);
                if (_designationManager.Update(category))
                {
                    ViewBag.SuccessMsg = "Updated";
                }
                else
                {
                    ViewBag.FailMsg = "Failed";
                }
            }
            else
            {
                ViewBag.FailMsg = "Validation Error";
            }
            return View(designationVm);
        }



    }
}