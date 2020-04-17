using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    public interface  IPaymentMethod
    {
        decimal DispatchmentFees { get; set; } 
        decimal Price(decimal price);
    }
    class BankTransfer : IPaymentMethod
    {
        public decimal DispatchmentFees { get; set; } = 5m;

        public decimal Price(decimal price)
        {
             var finalPrice = price + DispatchmentFees;
            
            return finalPrice;
        }
    }

    class CreditorDebitCard : IPaymentMethod
    {
        public decimal DispatchmentFees { get; set; } = 10m;

        public decimal Price(decimal price)
        {
            var finalPrice = price + DispatchmentFees;
            
            return finalPrice;
        }
    }
    class Cash : IPaymentMethod
    {
        public decimal DispatchmentFees { get; set; } = 0m;

        public decimal Price(decimal price)
        {
            return price;
        }
    }
}
