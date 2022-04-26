using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;

namespace Task1Decorator.Decorators
{
    public abstract class BoardDecorator : Motherboard
    {
        public abstract override string Description { get; }
    }
}

