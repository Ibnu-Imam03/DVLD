using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAcessLayer;
namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        public static bool IsExisted(string UserName, string Password)
        {
            return clsUserData.IsUserExisted(UserName, Password);
        }
        public static bool IsActive(string UserName)
        {
            return clsUserData.IsActive(UserName);
        }
    }
}
