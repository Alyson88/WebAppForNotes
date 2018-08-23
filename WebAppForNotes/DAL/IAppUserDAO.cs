using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppForNotes.Models;

namespace WebAppForNotes.DAL
{
    public interface IAppUserDAO
    {
        DataAppUserModel GetUser(string username);
        DataAppUserModel GetUser(string username, string password);
    }
}
