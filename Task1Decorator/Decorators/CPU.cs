using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator.Decorators
{
    public class CPU : BoardDecorator
    {
        private readonly Motherboard _motherboard;

        public CPU(Motherboard motherboard)
        {
            _motherboard = motherboard;
        }

        public override string Description => _motherboard.Description + ", with compatible CPU and RAM";

        public override double Cost()
        {
            return 306.48 + _motherboard.Cost();
        }
    }
}

