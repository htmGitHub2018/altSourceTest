using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Libs.Vendors
{
    public class CheckInventoryStep : IOrderProcessStep
    {
        public CheckInventoryStep(IOrderProcessStep nexStep)
        {
            NextStep = nexStep;
        }
        public IOrderProcessStep NextStep { get; set; }

        public Order ExecuteOrder(Order order)
        {
            //do something here!!
            return order;
        }
    }
}
