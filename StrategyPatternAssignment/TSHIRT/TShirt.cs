using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    class Shirt
    {
        public  Color Color { get; set; }
        public  Size Size { get; set; }
        public  Fabric Fabric { get; set; }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = (int)Color + (int)Size + (int)Fabric;
            }
        }

        public Shirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
        public void Output()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", Color, Size, Fabric);
        }
    }
}

