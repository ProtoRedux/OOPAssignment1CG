using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Decorator.Components
{
    /* this class is a specific class instance of a mother board and inherites properties from the abstract class motherboard */
    public class ASUS_ROG_Maximus : Motherboard
    {
        public ASUS_ROG_Maximus()
        {
            /* this line will override the unkown motherboard description found in the abstract class thanks to the get and set functions found in the 
            * inherited class */
            Description = "ASUS ROG Maximus XII Hero gaming motherboard";
        }
        /*In this class the cost method will override the method introduced in the abstract class. This means that multiple classes can use the same method 
        * but return differant set values*/
        public override double Cost()
        {
            /*This return value for the method found in this class is unique to this one motherboard and neither of the other two classes*/
            return 399.98;
        }
    }
}

