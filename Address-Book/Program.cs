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
                            method.PrintAddressbook();
                     break;   
                     case 5:
                            method.FindByCity();
                     break;
                     case 6:
                            method.CountAddressbook();
                     break;
                     case 7:
                            method.ReadFromStreamReader();
                     break;
                     case 8:
                            method.ConvertToCSV();
                     break;
                     case 9:
                            method.ConvertToJSON();
                     break;
                     case 10:
                            System.Environment.Exit(0);
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


