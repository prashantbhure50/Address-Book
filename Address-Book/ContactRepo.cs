using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Address_Book
{
   public class ContactRepo
    {
        public static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=AddresssbookDatabase;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetAllData()
        {
            try
            {
                ContactModle addressModel = new ContactModle();
                using (this.connection)
                {
                    string query = @"Select * from AddresssbookDatabase;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
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

        internal bool AddContact(Address address)
        {
            throw new NotImplementedException();
        }

        public bool AddContact(ContactModle model)
        {
            try
            {
                using (this.connection)
                {
                   
                    SqlCommand command = new SqlCommand("SpAddContactDetail", this.connection);
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

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
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
                this.connection.Close();
            }
            return false;
        }

        //public bool UpdateSalary(Address model)
        //{
        //    try
        //    {
        //        using (this.connection)
        //        {
        //            //var qury=values()
        //            SqlCommand command = new SqlCommand("spUpdateEmployeeSalary", this.connection);
        //            command.CommandType = System.Data.CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@Id", model.ID);
        //            command.Parameters.AddWithValue("@salary", model.salary);
        //            this.connection.Open();
        //            var result = command.ExecuteNonQuery();
        //            this.connection.Close();
        //            if (result != 0)
        //            {

        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        this.connection.Close();
        //    }
        //    return false;
        //}
    }
}
