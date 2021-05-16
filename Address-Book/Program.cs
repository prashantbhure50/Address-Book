﻿using System;
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
                            method.ADD_ADDRESSBOOK();
                     break;
                     case 2:
                            method.EDIT_ADDRESSBOOK();
                     break;
                     case 3:
                            method.DELETE_ADDRESSBOOK();
                     break;
                     case 4:
                            method.PRINT_ADDRESSBOOK();
                     break;   
                     case 5:
                            method.FIND_BY_CITY();
                     break;
                     case 6:
                            method.COUNT_ADDRESSBOOK();
                     break;
                     case 7:
                            method.ReadFromStreamReader();
                     break;
                     case 8:
                            method.CONVERT_TO_JSON();
                     break;
                     case 9:
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


