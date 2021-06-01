using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Address_Book
{
   public class ContactRepo
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=AddresssbookDatabase;Integrated Security=True";
       
        public void GetAllData()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                ContactModle addressModel = new ContactModle();
                using (connection)
                {
                    string query = @"Select * from AddresssbookDatabase;";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressModel.FirstName = dr.GetString(0);
                            addressModel.LastName = dr.GetString(1);
                            addressModel.AddressDetail = dr.GetString(2);
                            addressModel.State = dr.GetString(3);
                            addressModel.City = dr.GetString(4);
                            addressModel.PhoneNo = dr.GetString(5);
                            addressModel.Zip = dr.GetString(6);
                            addressModel.Email = dr.GetString(7);
                            addressModel.Type = dr.GetString(7);
                            System.Console.WriteLine(addressModel.FirstName + " " + addressModel.LastName + " " + addressModel.AddressDetail + " " + addressModel.State + " " + addressModel.City + " " + addressModel.PhoneNo + " " + addressModel.Zip  + " " + addressModel.Email+ " " +addressModel.Type);
                            System.Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        public void GetAllCountData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                ContactModle addressModel = new ContactModle();
                using (connection)
                {
                     string query = @"select count(*) from AddresssbookDatabase Where City='Bilaspur';";
                    //string query = @"select FirstName,City from AddresssbookDatabase where City='Bilaspur'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Number Of Person In Same City - "+ count);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        internal bool AddContact(Address address)
        {
            throw new NotImplementedException();
        }
        public bool AddContact(ContactModle model)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                using (connection)
                {
                   
                    SqlCommand command = new SqlCommand("SpAddContactDetail", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Addressdetail", model.AddressDetail);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@PhoneNo", model.PhoneNo);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    command.Parameters.AddWithValue("@Type", model.Type);

                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool EditContactByFirstName(ContactModle modle)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                { 
                    SqlCommand command = new SqlCommand("EditContact", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", modle.FirstName);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool DeleteContactByFirstName(ContactModle modle)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
             
                using (connection)
                {
                    
                    SqlCommand command = new SqlCommand("DeleteContact", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", modle.FirstName);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
