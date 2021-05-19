﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Address_Book
{
   public  class Methods
    {
       private Dictionary<string, Address> addressbook = new Dictionary<string, Address>();
       string path = @"C:\Users\prash\source\repos\Address-Book\Address-Book\ContactData.csv";
        
         public  void AddAddressbook()
        {
            try
            {
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
                addressbook.Add(FirstName, address);
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
      public void PreDedinedcontactList()
        {
            Address address0 = new Address("alok", "Bhure", "Tifra", "Bilaspur", "Chhattisgarh", "7000593588", "495223", "Aloktbhure50@gmail.com");
            Address address1 = new Address("Prashant", "Bhure", "Tifra", "Bilaspur", "Chhattisgarh", "8965940302", "495223", "prashantbhure@gmail.com");
            Address address2 = new Address("Ashish", "Gupta", "BTM", "Bengaluru", "Karanataka", "7000593588", "560076", "AshishGupta@gmail.com");
            Address address3 = new Address("Manish", "Sharma", "Andheri", "Mumbai", "Maharastra", "7456732456", "63456", "Manishsharma@gmail.com");
            Address address4 = new Address("Shahshank", "Gupta", "Nirakia", "korba", "Chhattisgarh", "9874920382", "489223", "Shashankgupta@gmail.com");
            addressbook.Add(address0.FirstName, address0);
            addressbook.Add(address1.FirstName, address1);
            addressbook.Add(address2.FirstName, address2);
            addressbook.Add(address3.FirstName, address3);
            addressbook.Add(address4.FirstName, address4);
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
        public void PrintSortedAddressbook()
        {
            var items = from pair in addressbook
               orderby pair.Key ascending
                        select pair;
            foreach (KeyValuePair <string, Address> contact in items)
            {
              Console.WriteLine(contact.Value.FirstName+", "+contact.Value.LastName+", "+contact.Value.AddressDetail+", "+contact.Value.City+", "+contact.Value.State+", "+contact.Value.PhoneNo+", "+contact.Value.Zip);                    
            }
        }
        public void FileIo()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine();
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
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
            Console.WriteLine(" Total Number Of Contact In AddressBook Are - "+ addressbook.Count); 
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
