using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppForNotes.Controllers
{
    public class CheatSheetController : Controller
    {
        // GET: CheatSheet
        public ActionResult Index()
        {
            return View();
        }
    }
}