using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();
            //InterfaceGercek1();
        }

        private static void InterfaceGercek1()
        {
            CustomerManager customM = new CustomerManager();
            customM.Add(new SqlServerCustomerDal());
            Console.ReadKey();
            customM.Add(new OracleServerCustomerDal());
            Console.ReadKey();
        }

        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Bahadır", LastName = "Meriç", Address = "Küçükçekmece" });
            Console.ReadKey();
            manager.Add(new Student { Id = 1, FirstName = "Kemal", LastName = "Kara", Departman = "Yazılım" });
            Console.ReadKey();
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departman { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departman { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
