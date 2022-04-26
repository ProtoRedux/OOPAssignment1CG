using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Decorator.Components
{
    public class ASUS_ROG_Crosshair : Motherboard
    {
        public ASUS_ROG_Crosshair()
        {
            Description = "ASUS ROG Crosshair VIII Impact, X570";
        }

        public override double Cost()
        {
            return 349.35;
        }
    }
}

