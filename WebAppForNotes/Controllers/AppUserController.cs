using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppForNotes.DAL;
using WebAppForNotes.Models;

namespace WebAppForNotes.Controllers
{
    public class AppUserController : MasterController
    {
        private readonly IAppUserDAO appUserDAO;

        public AppUserController(IAppUserDAO appUserDAO) : base(appUserDAO)
        {
            this.appUserDAO = appUserDAO;
        }

        public ActionResult Index()
        {
            var model = new AppUserViewModel();
            model.AppUserLoginModel = new AppUserLoginModel();
            model.AppUserRegisterModel = new AppUserRegisterModel();
            return View(model);
        }
    }
}