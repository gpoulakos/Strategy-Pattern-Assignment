using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    class PaymentProcedure
    {
        private IPaymentMethod _payment;

        public void SetPaymentMethod(IPaymentMethod paymentMethod) => _payment = paymentMethod;

        public void Price(decimal addtocart)
        {
            var totalprice = _payment.Price(addtocart);
            Console.WriteLine("Total price is: " + totalprice + " euros");
        }
    }
}
