using System;
using System.Data;
using DVLD_DataAcessLayer;

namespace DVLD_BusinessLayer
{
    public class clsPeople
    {
        public static DataTable GetAllPeoeple()
        {
            return clsPeopleDataAcess.GetAllPeople();
        }
    }
}
