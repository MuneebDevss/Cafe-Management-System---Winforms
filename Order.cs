using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    public class Order
    {
        public string orderid;
        public string discount;
        public static int Ordernum=1;
        public string CustomerID { get; set; }
        public String TotalPrice { get; set; }
        public string ItemID { get; set; }


        // Constructor
        public Order(string customerID, String totalPrice, string itemID,string disc)
        {
            discount= disc;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            ItemID = itemID;
            orderid = Ordernum.ToString();
            Ordernum++;

        }


        public Order()
        {
            
        }
    }

}
