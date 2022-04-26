using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Decorators;
using Task1Decorator.Components;

namespace Task1Decorator.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Whip";
    }
}
