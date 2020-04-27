using CAS_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using CAS_DAL;
namespace CAS_Repo
{

    public class LoginRepo : ILogin
    {
        ProjectEntities db = new ProjectEntities();
        public Login ValidateUser(string Username, string Password)
        {
            Login user = db.Logins.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
            return user;
        }
    }
}
