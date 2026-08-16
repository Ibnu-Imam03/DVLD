    using System;
    using System.Data;
    using System.Data.SqlClient;


    namespace DVLD_DataAcessLayer
    {
        public class clsPeopleDataAcess

        {
            public  static DataTable GetAllPeople()
            {
                DataTable TbPeople = new DataTable();
                SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);
                string query = "SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName , LastName ,DateOfBirth , Gendor , CountryName , Phone , Email  " +
                    "   FROM People   JOIN   Countries   ON Countries.CountryID = NationalityCountryID ";

                SqlCommand command =  new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader Reader = command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        TbPeople.Load(Reader);
                    }

                    Reader.Close();

                }
                catch (Exception ex)
                {

                }
                finally { connection.Close(); }

                return TbPeople;

            }


            public static DataTable GetPeopleBy(string Column , string Name)
        {
            DataTable TbPeople = new DataTable();
            SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);
            string query = "SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName , LastName ,DateOfBirth , Gendor , CountryName , Phone , Email  " +
                $"   FROM People   JOIN   Countries   ON Countries.CountryID = NationalityCountryID Where {Column} = @Data ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Data", Name);


            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    TbPeople.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

            return TbPeople;
        }

            public static DataTable GetPeopleBy(string Column, int Name)
        {
            DataTable TbPeople = new DataTable();
            SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);
            string query = "SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName , LastName ,DateOfBirth , Gendor , CountryName , Phone , Email  " +
                $"   FROM People   JOIN   Countries   ON Countries.CountryID = NationalityCountryID Where {Column} = @Data ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Data", Name);


            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    TbPeople.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

            return TbPeople;
        }



            public static int AddNewPerson (string NationalNo , string FirstName , string SecondName , string ThirdName , string LastName , 
                    DateTime DateOfBirth , string Gendor , string Address , string Phone , string Email , int NationalityCountryID , string ImagePath)
        {

            int PersonID = -1; 
            SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);

            string query = "INSERT INTO People (NationalNo , FirstName , SecondName , ThirdName , LastName ,  DateOfBirth ,  Gendor ," +
                "  Address ,  Phone ,  Email ,  NationalityCountryID ,  ImagePath) " +
                "  VALUES (@NationalNo , @FirstName , @SecondName , @ThirdName , @LastName ,  @DateOfBirth ,  @Gendor ," +
                "  @Address ,  @Phone ,  @Email , @NationalityCountryID , @ImagePath);  SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo); 
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID)){
                    PersonID = InsertedID;
                }
                if (result != null)
                {
                    PersonID = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return PersonID;

        }


            public static bool IsNationalIDExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);
            string query = "SELECT FOUND=1 FROM People  Where NationalNo = @NationalNo"; 
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader resault = command.ExecuteReader();

                if (resault.HasRows)
                {
                    IsFound = true;
                }
                

            }
            catch(Exception ex)
            {
                IsFound=false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

    }
}
