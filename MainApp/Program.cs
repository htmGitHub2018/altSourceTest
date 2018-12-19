using MainApp.Libs;
using MainApp.Libs.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("List of kind of vendors");
            VendorA vendor1 = new VendorA
            {
                Name = "Vendor Kind 1"
            };
            VendorB vendor2 = new VendorB
            {
                Name = "Vendor Kind 2"
            };

            Console.WriteLine($"{vendor1.Name}");
            Console.WriteLine($"{vendor2.Name}");
            Console.WriteLine("Which vendor's products you would like to buy or sell: type 1 or 2");
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.KeyChar == '1')
            {
                Console.WriteLine();
                renderProductInfo(vendor1);
            }else
            {
                renderProductInfo(vendor2);
            }
            Console.ReadLine();
        }

        private static void renderProductInfo(IVendor vendor)
        {
            List<IProduct> products = vendor.GetProductList();
            StringBuilder str = new StringBuilder();
            Console.WriteLine();
            Console.WriteLine("Product to buy:");
            foreach (var product in products)
            {
                var materials = product.GetMaterials();
                str.AppendLine($"Product type : {product.GetType().Name}");
                str.AppendLine($"{((ProductBase)product).Name} : Sell price: {product.SellPrice} : Buy price: {product.BuyPrice}");
                str.AppendLine("============================\n");
                foreach (var material in materials)
                {
                    str.AppendLine($"size: {material.Size} : colors: {string.Join(",", material.Colors)}");
                }
                str.AppendLine();
            }
            Console.WriteLine(str.ToString());
        }
    }
}
