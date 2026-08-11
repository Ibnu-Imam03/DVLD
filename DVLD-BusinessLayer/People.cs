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

        public static DataTable GetPerson(string Column , string Data)
        {
            return clsPeopleDataAcess.GetPeopleBy(Column , Data);
        }
        public static DataTable GetPerson(string Column, int Data)
        {
            return clsPeopleDataAcess.GetPeopleBy(Column, Data);
        }
      


        
    }
}
