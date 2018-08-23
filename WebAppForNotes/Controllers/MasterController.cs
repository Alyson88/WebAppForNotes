using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppForNotes.DAL;
using WebAppForNotes.Models;

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

        public string CurrentUser
        {
            get
            {
                string username = string.Empty;

                if (Response.Cookies != null)
                {
                    var cookies = Response.Cookies;
                }
                if(Session[UsernameKey] != null)
                {
                    username = Session[UsernameKey] as string;
                }
                return username;
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return Session[UsernameKey] != null;
            }
        }

        public void LogUserIn(string username)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", "username"));
            Session[UsernameKey] = username;
        }

        public void LogUserOut()
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        }

        [ChildActionOnly]
        public ActionResult GetAuthenticatedUser()
        {
            DataAppUserModel model = null;

            if (IsAuthenticated)
            {
                model = appUserDAO.GetUser(CurrentUser);
            }
            return PartialView("_AuthenticationBar", model);
        }
    }
}