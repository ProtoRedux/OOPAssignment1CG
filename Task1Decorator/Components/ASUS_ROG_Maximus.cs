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
            Description = "ASUS ROG Maximus XII Hero gaming motherboard";
        }

        public override double Cost()
        {
            return 399.98;
        }
    }
}

