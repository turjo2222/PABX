using AutoMapper;
using PabxInfo.BLL.BLL;
using PabxInfo.Models;
using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PabxInfo.Controllers
{
    public class ClientController : Controller
    {
        ClientManager _clientManager = new ClientManager();
        DesignationManager _designationManager = new DesignationManager();

        private Client _client = new Client();

        // GET: client
        [HttpGet]
        public ActionResult Index()
        {
            ClientAddViewModel clientVm = new ClientAddViewModel();
            clientVm.DesignationSelectListItem = _designationManager.GetAll()
                .Select(c => new SelectListItem()
                {
                    Value = c.ID.ToString(),
                    Text = c.DesignationName
                })
                .ToList();

            return View(clientVm);
        }
        // Post: Designation
        [HttpPost]
        public ActionResult Index(ClientAddViewModel clientVm)
        {
            if (ModelState.IsValid)
            {
                var client = Mapper.Map<Client>(clientVm);

                if (_clientManager.Add(client))
                {
                    ViewBag.SuccesMsg = "Saved";
                }
                else
                {
                    ViewBag.FailedMsg = "Failed";
                }
            }
            else ViewBag.FailedMsg = "Validation Failed";
            clientVm.DesignationSelectListItem = _designationManager.GetAll()
                          .Select(c => new SelectListItem()
                             {
                                 Value = c.ID.ToString(),
                                 Text = c.DesignationName
                             })
                .ToList();

            return View(clientVm);

        }
    }
}