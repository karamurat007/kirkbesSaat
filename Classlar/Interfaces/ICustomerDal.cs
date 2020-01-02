using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Delete");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server Update");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Update");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
    }
}
