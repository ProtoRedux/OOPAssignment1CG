using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Observer.Observers
{
    //The observer interface is attached to objects to update their held values if any linked subjects values change.
    public interface IObserver
    {
        //This interface will run the update method for each of the subjects values. 
        void Update(int manga, int problemsheet, int lightnovel);
    }
}

