using AutoMapper;
using PabxInfo.Models;
using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PabxInfo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg => {
                cfg.CreateMap<ClientAddViewModel, Client>();
                cfg.CreateMap<Client, ClientAddViewModel>();
                cfg.CreateMap<DesignationAddViewModel, Designation>();
                cfg.CreateMap<Designation, DesignationAddViewModel>();
            });
        }
    }
}
