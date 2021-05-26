using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
   public class Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressDetail { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
       public Address(string FirstName, string LastName, string AddressDetail, string City, string State, string PhoneNo, string Zip, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AddressDetail = AddressDetail;
            this.City = City;
            this.State = State;
            this.PhoneNo = PhoneNo;
            this.Zip = Zip;
            this.Email = Email;
        }
        public static void printTitle()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Please Select Option");
            Console.WriteLine("1 - Add Contact");
            Console.WriteLine("2 - Edit Contact");
            Console.WriteLine("3 - Delete Contact");
            Console.WriteLine("4 - Print AddressBook");
            Console.WriteLine("5 - Search Contact By CITY OR STATE");
            Console.WriteLine("6 - View AdderssBook");
            Console.WriteLine("7 - Read And Write From File IO");
            Console.WriteLine("8 - Read And Write From File From CSV");
            Console.WriteLine("9 - Read And Write From File From JSON");
            Console.WriteLine("10 - Get All Data From DATABASE");
            Console.WriteLine("11 - Exit");
            Console.WriteLine("****************************************");
            
        }
    }
}
