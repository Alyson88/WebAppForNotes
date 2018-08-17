using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppForNotes.DAL;

namespace WebAppForNotes.Controllers
{
    public class MasterController : Controller
    {
        private const string UsernameKey = "AppUser_Username";
        private const string IsAdminKey = "IsAdmin";
        private readonly IAppUserDAO appUserDAO;

        public MasterController(IAppUserDAO appUserDAO)
        {
            this.appUserDAO = appUserDAO;
        }
    }
}