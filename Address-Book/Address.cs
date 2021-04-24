using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class Address
    {
        public string FirstName, LastName, AddressDetail, City, State, Email;
        public double PhoneNo, Zip;
        public Address(string FirstName, string LastName, string AddressDetail, string City, string State, double PhoneNo, double Zip, string Email)
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


            Console.WriteLine("Please Select Option");
            Console.WriteLine("1 - Add Contact");
            Console.WriteLine("2 - Edit Contact");
            Console.WriteLine("3 - Delete Contact");
            Console.WriteLine("4 - Print AddressBook");
            Console.WriteLine("5 -  Exit");

        }
    }
}
