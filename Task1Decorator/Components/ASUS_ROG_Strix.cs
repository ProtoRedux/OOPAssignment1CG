using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Decorator.Components
{
    public class ASUS_ROG_Strix : Motherboard
    {
        public ASUS_ROG_Strix()
        {
            Description = "ASUS ROG Strix X570-I gaming motherboard";
        }

        public override double Cost()
        {
            return 279.98;
        }
    }
}

