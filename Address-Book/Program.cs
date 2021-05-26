using System;
using System.Collections;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
           try 
           {
            Methods method = new Methods();
            ContactRepo repo = new ContactRepo(); 
            while (true)
             {
                Address.printTitle();                   
                int Check = Convert.ToInt32(Console.ReadLine());
                switch (Check)
                {
                     case 1:
                            method.AddAddressbook();
                     break;
                     case 2:
                            method.EditAddressbook();
                     break;
                     case 3:
                            method.DeleteAddressbook();
                     break;
                     case 4:
                            method.PrintSortedAddressbook();
                     break;   
                     case 5:
                            method.FindByCity();
                     break;
                     case 6:
                            method.CountAddressbook();
                     break;
                     case 7:
                            method.FileIo();
                     break;
                     case 8:
                            method.ConvertToCSV();
                     break;
                     case 9:
                            method.ConvertToJSON();
                     break;
                     case 10:
                            repo.GetAllData();
                     break;
                     case 11:
                            System.Environment.Exit(1);
                     break;
                }
            }
           }
           catch (Exception e)
           {
                Console.WriteLine(e); 
           }
        }
    }
}