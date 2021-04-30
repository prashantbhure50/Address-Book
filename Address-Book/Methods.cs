using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
   public  class Methods
    {
        ArrayList list = new ArrayList();
         public  void ADD_ADDRESSBOOK()
        {
            try
            {
                Console.WriteLine("Enter Person New FirstName");
                string FirstName = Console.ReadLine();
                foreach (Address contact in list)
                    if (FirstName.Equals(contact.FirstName))
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
                list.Add(new Address(FirstName, LastName, AddressDetail, City, State, PhoneNo, Zip, Email));
                Console.WriteLine("Contact Added Successfully");
            }
            catch (Exception e)
            { }    
         }
        public void EDIT_ADDRESSBOOK()
        {
            Console.WriteLine("Please Enter Name Which You Want To Edit");
            string Name = Console.ReadLine();
            foreach (Address contact in list)
                if (Name.Equals(contact.FirstName))
                {
                    Console.WriteLine("Enter new FirstName");
                    string NewFirestName = Console.ReadLine();
                    contact.FirstName = NewFirestName;

                }
            Console.WriteLine("Contact is Edited");
        }
        public void DELETE_ADDRESSBOOK()
        {
            Console.WriteLine("Please Enter Name Which You Want To Delete");
            string delete = Console.ReadLine();
            Address address = null;

            foreach (Address Contact in list)
            {
                if (Contact.FirstName == delete)
                {
                    address = Contact;
                }
            }
            list.Remove(address);
            Console.WriteLine("Contact Deleted Successfully");
        }
        public void PRINT_ADDRESSBOOK()
        {
            foreach (Address Contact in list)
            {
                Console.WriteLine(Contact.FirstName + ", " + Contact.LastName + ", " + Contact.AddressDetail + ", " + Contact.City + ", " + Contact.State + ", " + Contact.PhoneNo + ", " + Contact.Zip + ", " + Contact.Email);
            }
        }
    }
}
