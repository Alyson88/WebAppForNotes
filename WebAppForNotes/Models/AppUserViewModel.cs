using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppForNotes.Models
{
    public class AppUserViewModel
    {
        public AppUserLoginModel AppUserLogin { get; set; }

        public AppUserRegisterModel AppUserRegister { get; set; }
    }
}