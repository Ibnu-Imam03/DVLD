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
        public int UserID {  get; set; }
        public int PersonID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive {  get; set; }
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = string.Empty;
            IsActive = false;
            _Mode = enMode.AddNew;
        }

        public clsUser(string username, string password, int PersonID , int UserID , bool ISActive)
        {
            this.UserName = username;
            this.Password= password;
            this.PersonID = PersonID;
            this.UserID = UserID;
            this.IsActive = ISActive;
            _Mode = enMode.Update;
        }

        public static clsUser FindByUserNameAndPassword(string username, string password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;

            if (clsUserData.GetUserInfoByUsernameAndPassword(username, password, ref UserID, ref PersonID, ref IsActive))
            {
                return new clsUser(username, password, UserID, PersonID, IsActive);
            }
            else
            {
                return null;
            }
        }

        /////////////////////////////////////////////////////////
      
        public static bool IsExisted(string UserName, string Password)
        {
            return clsUserData.IsUserExisted(UserName, Password);
        }
        //public static bool IsActive(string UserName)
        //{
        //    return clsUserData.IsActive(UserName);
        //}
    }
}
