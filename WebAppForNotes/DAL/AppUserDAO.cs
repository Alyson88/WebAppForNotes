using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppForNotes.DAL
{
    public class AppUserDAO : IAppUserDAO
    {
        private readonly string connectionString;

        public AppUserDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}