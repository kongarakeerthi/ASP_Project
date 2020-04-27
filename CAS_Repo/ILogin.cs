using CAS_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CAS_DAL;
namespace CAS_Repo
{
    public interface ILogin
    {
        Login ValidateUser(string Username, string Password);  
    }
}
