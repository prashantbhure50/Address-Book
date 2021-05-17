using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Address_Book
{
   public  class Methods
    {
      
       private Dictionary<int, Address> addressbook = new Dictionary<int, Address>();
       string path = @"C:\Users\prash\source\repos\Address-Book\Address-Book\ContactData.csv";
        
         public  void AddAddressbook()
        {
            try
            {
                Console.WriteLine("Enter Unique  Key Value ");
                int key = Convert.ToInt32(Console.ReadLine());
                foreach (var contact in addressbook)
                    if (key.Equals(contact.Key))
                    {
                        Console.WriteLine("Key Is already Used Enter New Key !!");
                        AddAddressbook();
                    }
                Console.WriteLine("Enter Person New FirstName");
                string FirstName = Console.ReadLine();
                foreach (var contact in addressbook)
                    if (FirstName.Equals(contact.Value.FirstName))
                    {
                        Console.WriteLine("Contact Is Already Added In Your ADDRESSBOOK!!");
                        AddAddressbook();
                    }
                Console.WriteLine("Enter Person LastName");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Person AddressDetail");
                string AddressDetail = Console.ReadLine();
                Console.WriteLine("Enter Person City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter Person State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Person Email");
                string Email = Console.ReadLine();
                Console.WriteLine("Enter Person PhoneNumber");
                string PhoneNo = Console.ReadLine();
                Console.WriteLine("Enter Person Zip");
                string Zip = Console.ReadLine();
                Address address= new Address(FirstName, LastName, AddressDetail, City, State, PhoneNo, Zip, Email);
                addressbook.Add(key, address);
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(address.FirstName + "," + address.LastName + "," + address.AddressDetail + "," + address.City + "," + address.State + "," + address.PhoneNo + "," + address.Zip + "," + address.Email);
                    sr.Close();
                }
                Console.WriteLine("Contact Added Successfully");
            }
            catch (Exception e)
            { 
            }    
         }
        public void EditAddressbook()
        {
            Console.WriteLine("Please Enter Name Which You Want To Edit");
            string Name = Console.ReadLine();
            foreach (var contact in addressbook)
                if (Name.Equals(contact.Value.FirstName))
                {
                    Console.WriteLine("Enter new FirstName");
                    string NewFirestName = Console.ReadLine();
                    contact.Value.FirstName = NewFirestName;
                }
            Console.WriteLine("Contact is Edited");
        }
        public void DeleteAddressbook()
        {
            Console.WriteLine("Please Enter Name Which You Want To Delete");
            string delete = Console.ReadLine();
            foreach (var Contact in addressbook)
            {
                if (Contact.Value.FirstName == delete)
                {
                    addressbook.Remove(Contact.Key);
                }
            }   
            Console.WriteLine("Contact Deleted Successfully");
        }
        public void PrintAddressbook()
        {
            foreach (var Contact in addressbook)
            {
                Console.WriteLine(Contact.Value.FirstName + ", " + Contact.Value.LastName + ", " + Contact.Value.AddressDetail + ", " + Contact.Value.City + ", " + Contact.Value.State + ", " + Contact.Value.PhoneNo + ", " + Contact.Value.Zip + ", " + Contact.Value.Email);
            }
        }
        public void FindByCity()
        {
            Console.WriteLine("Please Enter The CITY  Name");
            string cityName = Console.ReadLine();
            foreach (var contact in addressbook)
                if (cityName.Equals(contact.Value.City))
                {
                    Console.WriteLine("FIRSTNAME - "+contact.Value.FirstName +", "+"CITY - "+ contact.Value.City);
                }
        }
        public void CountAddressbook()
        {
            Console.WriteLine("Total Number Of Contact In AddressBook Are - "+ addressbook.Count); 
        }
        public void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }    
        public void ConvertToJSON()
        {
            ContactToJson.ImplementCSVToJSon();
        }
        public void ConvertToCSV()
        {
            ContactToCSV.ImplementCSVDataHandling();
        }

    }
}
