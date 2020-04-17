using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    class TShirt
    {
        public  Color Color { get; set; }
        public  Size Size { get; set; }
        public  Fabric Fabric { get; set; }

        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = (decimal)Color + (decimal)Size + (decimal)Fabric;
            }
        }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
    }
}

