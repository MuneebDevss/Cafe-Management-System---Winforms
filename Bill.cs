using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    public class Bill
    {
        public decimal price; public string customerId;public string orderId; public string cashierId;
        public string billid;
        public Bill(string billid, decimal price, string customerId, string orderId, string cashierId) 
        {
            this.price = price;
            this.customerId = customerId;
            this.orderId = orderId;
            this.cashierId = cashierId;
            this.billid = billid;
        }
    }
}
