using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator.Decorators
{
    /* This creates a new class called fan which inherites from the board decorator instead of the motherboard abstract class*/
    public class CPU : BoardDecorator
    {
        /*This action prevents the motherboard values from changing after its object has initialised*/
        private readonly Motherboard _motherboard;

        /* this creates an object of the class fan with parameters from the motherboard class and a new motherboard parameter made below
 * this allows the fan object to take properties from whatever board object is initialised */
        public CPU(Motherboard motherboard)
        {
            /*This is used to link the properties of the mother board to the field*/
            _motherboard = motherboard;
        }
        /*This override allows the cost mthod to used by both the initial board object and the fan decorator object simultainiously*/
        public override string Description => _motherboard.Description + ", with compatible CPU";

        /*using the override, a value can be returned for the decorator while also enabling the motherboard to retain its own value.
        * this can now allow both values added together to be returned as the final value. */
        public override double Cost()
        {
            /*This override allows the existing board object description to be retained while also appending the decorators description*/
            return 306.48 + _motherboard.Cost();
        }
    }
}

