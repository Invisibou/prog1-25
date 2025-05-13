using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Customer
    {
        public int Id { get; set; }
        public  string? Name { get; set; }
        public string? HomeAdress { get; set; }
        public string? WorkAddres { get; set; }

        public static int InstanceCount = 0;
        public int ObjectCount = 0;

        public bool Validade()
        {
            return true;
        }
        public Customer Retrieve()
        {
            return new Customer();
        }

        public void Save(Customer customer)
        {


        }
    }
}
