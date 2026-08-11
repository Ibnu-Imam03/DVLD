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
        public static DataTable GetPeopleByDate(string Column, DateTime Name)
        {
            DataTable TbPeople = new DataTable();
            SqlConnection connection = new SqlConnection(PeopeleDatasettings.ConnectionString);
            string query = "SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName , LastName ,DateOfBirth , Gendor , CountryName , Phone , Email  " +
                $"   FROM People   JOIN   Countries   ON Countries.CountryID = NationalityCountryID Where {Column} = @Data WHERE DateOfBirth >= @Date\r\nAND DateOfBirth < DATEADD(day, 1, @Date)";

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




    }
}
