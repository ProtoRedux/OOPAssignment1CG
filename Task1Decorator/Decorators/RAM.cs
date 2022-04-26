using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator.Decorators
{
    public class RAM : BoardDecorator
    {
        private readonly Motherboard _motherboard;

        public RAM(Motherboard motherboard)
        {
            _motherboard = motherboard;
        }

        public override double Cost()
        {
            return 103.00 + _motherboard.Cost();
        }

        public override string Description => _motherboard.Description + ", with 16Gb compatible RAM";
    }
}

