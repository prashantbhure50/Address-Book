using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Welcome To AdressBook");
            Console.WriteLine("Enter Person FirstName");
            string FirstName = Console.ReadLine();
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
            int PhoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person Zip");
            int Zip = Convert.ToInt32(Console.ReadLine());
            list.Add(new Address(FirstName, LastName, AddressDetail, City, State, 7000593588, 495223, Email));

            foreach (Address Contact in list)
            {
                Console.WriteLine(Contact.FirstName + ", " + Contact.LastName + ", " + Contact.AddressDetail + ", " + Contact.City + ", " + Contact.State + ", " + Contact.PhoneNo + ", " + Contact.Zip + ", " + Contact.Email);
            }
        }
    }
}
