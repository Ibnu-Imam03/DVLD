using DVLD_DataAcessLayer;
using System;
using System.Data;
using System.Net;

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


        public clsPeople()
        {

        }

        private clsPeople(int PersonID,  string NationalNo,  string FirstName,  string SecondName,  string ThirdName, 
             string LastName,  DateTime DateOfBirth,  int Gendor,  string Address,  string Phone,  string Email,  int NationalityCountryID,  string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
        }

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

        public clsPeople Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

             if (clsPeopleDataAcess.GetPeopleByPersonID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new  clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName,
              LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

            
        }
    }
}
