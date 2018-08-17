using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppForNotes.DAL;

namespace WebAppForNotes.Controllers
{
    public class HowToController : MasterController
    {
        private readonly IAppUserDAO appUserDAO;

        public HowToController(IAppUserDAO appUserDAO) : base(appUserDAO)
        {
            this.appUserDAO = appUserDAO;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}