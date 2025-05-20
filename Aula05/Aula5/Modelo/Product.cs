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
            bool isValid = true;

            isValid = !string.IsNullOrEmpty(this.Name) && (this.IdProduct > 0) && (this.CurrentPrice > 0);

            return isValid;
        }
        
    }
}
