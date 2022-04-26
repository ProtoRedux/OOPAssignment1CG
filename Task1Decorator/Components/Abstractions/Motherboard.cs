using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Decorator.Components
{
    /* This is the abstract class that holds the general features of each component, all subsequent classes will inherit the information held here.  */
    public abstract class Motherboard
    {
        /* this line generates a base description of the motherboard, this will be overridden but whatever class is selected */
        public virtual string Description { get; protected set; } = "Unknown Motherboard";

        /* this line prepares the method that will determine the cost of the selected component */
        public abstract double Cost();
    }
}

