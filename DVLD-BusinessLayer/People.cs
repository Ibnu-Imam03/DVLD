using System;
using System.Data;
using DVLD_DataAcessLayer;

namespace DVLD_BusinessLayer
{
    public class clsPeople
    {

        public int PersonID {  get; set; } 
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public enum enMode { AddNew=0, Update=1 };
        public enMode Mode = enMode.AddNew;


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
        
        
        private  bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAcess.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                                                             Address, Phone, Email, NationalityCountryID, ImagePath);

            return this.PersonID != -1;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else 
                        { 
                            return false;
                        } 

                    }
                   
            }
            return false;
        }

        public static bool IsNationalIDExist(string NID)
        {
            return clsPeopleDataAcess.IsNationalIDExist(NID);
        }
    }
}
