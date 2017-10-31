using AutoMapper;
using Biztek.Paisadeal.App.Entities;
using Biztek.Paisadeal.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Biztek.Paisadeal.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapper.Initialize(cfg =>{
                cfg.CreateMap<TypeOFLoanViewModel, TypeOFLoan>();
                cfg.CreateMap<TypeOFLoan, TypeOFLoanViewModel>();
                cfg.CreateMap<CreditInformationViewModel, CreditInformation>();
                cfg.CreateMap<CreditInformation, CreditInformationViewModel>();
            });
        }
    }
}
