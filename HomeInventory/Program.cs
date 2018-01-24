using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Products();
            product.ProductName = "Sofa";
            product.PurchasedPrice = 1000M;
            product.DatePurchased = new DateTime(2012, 1, 14);
            product.ExpiryDate = new DateTime(2018, 1, 14);

           // if (product.IsExpired())
                Console.WriteLine($"PN:{product.ProductName}, bought at PP:{product.PurchasedPrice}, has expired today ED:{product.ExpiryDate.Date}");
           
        }
    }
}
