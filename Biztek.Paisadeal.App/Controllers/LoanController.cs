using AutoMapper;
using Biztek.Paisadeal.App.Entities;
using Biztek.Paisadeal.App.Models;
using Exceptionless;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Biztek.Paisadeal.App.Controllers
{
    public class LoanController : Controller
    {

        // GET: Loan
        public ActionResult Index(string loan)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                {
                    return RedirectToAction("Login", "Account", "returnUrl=" + this.Url);
                }

                var defaultModel = new TypeOFLoanViewModel(loan);
                var userId = User.Identity.GetUserId();
                using (var context = new PaisadealContext())
                {
                    var typeOfLoan = context.TypeOFLoans.FirstOrDefault(x => x.UserId == userId);
                    if (typeOfLoan != null)
                    {
                        defaultModel = Mapper.Map<TypeOFLoan, TypeOFLoanViewModel>(typeOfLoan);
                        defaultModel.SelectedEmployeeType = typeOfLoan.EmployeeType;
                        defaultModel.SelectedLoanType = typeOfLoan.LoanType;
                    }
                }
                return View(defaultModel);

            }
            catch (Exception ex)
            {
                ex.ToExceptionless().Submit();
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TypeOFLoanViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var defaultModel = new CreditInformationViewModel();
                var userId = User.Identity.GetUserId();
                using (var context = new PaisadealContext())
                {
                    var typeOfLoan = context.TypeOFLoans.SingleOrDefault(x => x.UserId == userId);
                    if (typeOfLoan != null)
                    {
                        Mapper.Map(model, typeOfLoan);
                        context.Entry(typeOfLoan).State = EntityState.Modified;
                    }
                    else
                    {
                        var dbEntity = Mapper.Map<TypeOFLoanViewModel, TypeOFLoan>(model);
                        dbEntity.UserId = userId;
                        context.TypeOFLoans.Add(dbEntity);
                    }

                    context.SaveChanges();

                    var creditInfo = context.CreditInformations.FirstOrDefault(x => x.UserId == userId);
                    if (creditInfo != null)
                    {
                        defaultModel = Mapper.Map<CreditInformationViewModel>(creditInfo);
                    }
                }

                return View("CreditInformation", defaultModel);
            }
            catch (Exception ex)
            {
                ex.ToExceptionless().Submit();
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreditInformation(CreditInformationViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var userId = User.Identity.GetUserId();
                using (var context = new PaisadealContext())
                {
                    var creditInfo = context.CreditInformations.SingleOrDefault(x => x.UserId == userId);
                    if (creditInfo != null)
                    {
                        Mapper.Map(model, creditInfo);
                        context.Entry(creditInfo).State = EntityState.Modified;
                    }
                    else
                    {
                        var dbEntity = Mapper.Map<CreditInformationViewModel, CreditInformation>(model);
                        dbEntity.UserId = userId;
                        context.CreditInformations.Add(dbEntity);
                    }

                    context.SaveChanges();

                }
                return View(model);

            }
            catch (Exception ex)
            {
                ex.ToExceptionless().Submit();
                throw;
            }        }
    }
}