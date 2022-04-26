using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator.Decorators
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Soy";
    }
}

