using MainApp.Libs.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs.Vendors
{
    public class VendorA: VendorBase
    {
        public override Order ExecuteOrder(IOrderProcessStep process,Order info)
        {
            IOrderProcessStep firstStep = new CheckInventoryStep(new CreateInvoiceStep());
            return firstStep.ExecuteOrder(info);
        }

        public override List<IProduct> GetProductList()
        {
            //for different vendor we can have dirrent sell /buy price for each product type
            DressShirt dressShirt = new DressShirt
            {
                SellPrice = 20,
                BuyPrice = 8
            };
            TShirt tshirt = new TShirt
            {
                SellPrice = 12,
                BuyPrice = 6
            };
            return new List<IProduct> { dressShirt, tshirt };
        }
    }
}
