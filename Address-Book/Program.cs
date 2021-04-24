using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                Address.printTitle();
                int Check = Convert.ToInt32(Console.ReadLine());
                switch (Check)
                {
                    case 1:
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
                        break;
                    case 2:
                        Console.WriteLine("Please Enter Name Which You Want To Edit");
                        string Name = Console.ReadLine();
                        foreach (Address contact in list)
                            if (Name.Equals(contact.FirstName))
                            {
                                Console.WriteLine("Enter new FirstName");
                                string NewFirestName = Console.ReadLine();
                                contact.FirstName = NewFirestName;

                            }
                        break;
                }
            }
        }
    }
}

