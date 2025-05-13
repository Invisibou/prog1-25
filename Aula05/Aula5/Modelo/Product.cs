using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float CurrentPrice { get; set; }
        public bool Validade()
        {
            return true;
        }
        public Product Retrieve()
        {
            return new Product();
        }

        public void Save(Product product)
        {


        }
    }
}
