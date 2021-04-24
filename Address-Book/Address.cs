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
    }
}
