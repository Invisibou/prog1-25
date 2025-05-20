using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Order
    {
        #region Atributos
        public int Id { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public Adress ShippingAddress { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        #endregion

        public Order() //Você ta criando um objeto, não precisa retornar nada no parâmetro, afinal, ele está construindo ele mesmo
        {
            OrderDate = DateTime.Now;
            OrderItems = new List<OrderItem>();
            // aqui eu mudo
        }

        public Order(int orderId) : this()  
        {
            this.Id = orderId;            
        }

        public Order(int orderId, string address) : this(orderId)
        {
            this.Id = orderId;
            this.ShippingAddress = $"Endereço {orderId}";
        }

        public bool Validade()
        {
           return true;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        
    }
}