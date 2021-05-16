using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;


namespace Address_Book
{
   public class ContactToJson
    {
        public static void ImplementCSVToJSon()
        {
            string importFilePath = @"C:\Users\prash\source\repos\Address-Book\Address-Book\ContactData.csv";
            string exportFilePath = @"C:\Users\prash\source\repos\Address-Book\Address-Book\Utility\ContactToJSON.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Address>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (Address addressData in records)
                {
                    Console.WriteLine("\t" + addressData.FirstName);
                    Console.WriteLine("\t" + addressData.LastName);
                    Console.WriteLine("\t" + addressData.AddressDetail);
                    Console.WriteLine("\t" + addressData.City);
                    Console.WriteLine("\t" + addressData.State);
                    Console.WriteLine("\t" + addressData.PhoneNo);
                    Console.WriteLine("\t" + addressData.Zip);
                    Console.WriteLine("\t" + addressData.Email);

                }
                Console.WriteLine("*******************Reading form Csv file and Write to JSON file");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }

            }
        }
    }
}
