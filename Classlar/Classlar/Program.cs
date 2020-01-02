using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Id = 1;
            cust.City = "İstanbul";
            cust.FirstName = "Bahadir";
            cust.LastName = "Meriç";

            Customer cust2 = new Customer
            { 
                Id=2, 
                City="Bursa", 
                FirstName="Kemal", 
                LastName="Kara"
            };

            Console.WriteLine($"ID : {cust.Id} | FirstName : {cust.FirstName}");
            Console.WriteLine($"ID : {cust2.Id} | FirstName : {cust2.FirstName}");
            Console.ReadKey();
        }
    }
}
