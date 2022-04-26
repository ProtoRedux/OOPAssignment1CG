using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Decorator.Components
{
    /*prepares a new class for a specific motherboard. This class will inherit from the motherboard abstract class */ 
    public class ASUS_ROG_Crosshair : Motherboard
    {
        public ASUS_ROG_Crosshair()
        {
            /* this line will override the unkown motherboard description found in the abstract class thanks to the get and set functions found in the 
             * inherited class */
            Description = "ASUS ROG Crosshair VIII Impact, X570";
        }
        /*In this class the cost method will override the method introduced in the abstract class. This means that multiple classes can use the same method 
         * but return differant set values*/
        public override double Cost()
        {
            /*This return value for the method found in this class is unique to this one motherboard and neither of the other two classes*/
            return 349.35;
        }
    }
}

