using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Decorators;
using Task1Decorator.Components;

namespace Task1Decorator.Decorators
{
    public class Fan : BoardDecorator
    {
        private readonly Motherboard _motherboard;

        public Fan(Motherboard motherboard)
        {
            _motherboard = motherboard;
        }

        public override double Cost()
        {
            return 79.99 + _motherboard.Cost();
        }

        public override string Description => _motherboard.Description + ", Compatible Cooling Fan";
    }
}
