using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Observer.Observers
{
    //The display interface will allow any object to report when an observer detacts a change in the subjects values.
    public interface IDisplayElement
    {
        void Display();
    }
}

