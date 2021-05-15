using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
   public  class Methods
    {
      
       private Dictionary<int , Address> Addressbook = new Dictionary<int , Address>();
         public  void ADD_ADDRESSBOOK()
        {
            try
            {
                Console.WriteLine("Enter Unique  Key Value FirstName");
                int key = Convert.ToInt32(Console.ReadLine());
                foreach (var contact in Addressbook)
                    if (key.Equals(contact.Key))
                    {
                        Console.WriteLine("Key Is already Used Enter New Key !!");
                        ADD_ADDRESSBOOK();
                    }
                Console.WriteLine("Enter Person New FirstName");
                string FirstName = Console.ReadLine();
                foreach (var contact in Addressbook)
                    if (FirstName.Equals(contact.Value.FirstName))
                    {
                        Console.WriteLine("Contact Is Already Added In Your ADDRESSBOOK!!");
                        Console.WriteLine();
                        Console.WriteLine();
                        ADD_ADDRESSBOOK();
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
                Address a= new Address(FirstName, LastName, AddressDetail, City, State, PhoneNo, Zip, Email);
                Addressbook.Add(key, a);
                Console.WriteLine("Contact Added Successfully");
            }
            catch (Exception e)
            { }    
         }
        public void EDIT_ADDRESSBOOK()
        {
            Console.WriteLine("Please Enter Name Which You Want To Edit");
            string Name = Console.ReadLine();
            foreach (var contact in Addressbook)
                if (Name.Equals(contact.Value.FirstName))
                {
                    Console.WriteLine("Enter new FirstName");
                    string NewFirestName = Console.ReadLine();
                    contact.Value.FirstName = NewFirestName;
                }
            Console.WriteLine("Contact is Edited");
        }
        public void DELETE_ADDRESSBOOK()
        {
            Console.WriteLine("Please Enter Name Which You Want To Delete");
            string delete = Console.ReadLine();
            foreach (var Contact in Addressbook)
            {
                if (Contact.Value.FirstName == delete)
                {
                    Addressbook.Remove(Contact.Key);
                }
            }   
            Console.WriteLine("Contact Deleted Successfully");
        }
        public void PRINT_ADDRESSBOOK()
        {
            foreach (var Contact in Addressbook)
            {
                Console.WriteLine(Contact.Value.FirstName + ", " + Contact.Value.LastName + ", " + Contact.Value.AddressDetail + ", " + Contact.Value.City + ", " + Contact.Value.State + ", " + Contact.Value.PhoneNo + ", " + Contact.Value.Zip + ", " + Contact.Value.Email);
            }
        }
        public void FIND_BY_CITY()
        {
            Console.WriteLine("Please Enter The CITY  Name");
            string cityName = Console.ReadLine();
            foreach (var contact in Addressbook)
                if (cityName.Equals(contact.Value.City))
                {
                    Console.WriteLine("FIRSTNAME - "+contact.Value.FirstName +", "+"CITY - "+ contact.Value.City);
                }
        }
        public void COUNT_ADDRESSBOOK()
        {
            Console.WriteLine("Total Number Of Contact In AddressBook Are - "+ Addressbook.Count); 
        }
    }
}
