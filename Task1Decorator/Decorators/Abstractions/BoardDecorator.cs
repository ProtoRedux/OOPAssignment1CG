using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;

namespace Task1Decorator.Decorators
{
    /* this creates an abstract class for the decorators, this abstract class also inherites from the Motherboard abstract class*/
    public abstract class BoardDecorator : Motherboard
    {
        /*This function will override the get description function used in the parent class this is necessary to use the function in the decorators */
        public abstract override string Description { get; }
    }
}

