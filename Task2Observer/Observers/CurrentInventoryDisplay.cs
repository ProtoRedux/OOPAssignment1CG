using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Observer.Subjects;

namespace Task2Observer.Observers
{
    //class possessing two interfaces: an observer and display interface the observer interface
    //allows this class to view changed made in the object possessing the subject interface.
    public class CurrentInventoryDisplay : IObserver, IDisplayElement
    {
        //each of the integers below are made readonly fields to prevent them being potentially manipulated elasewhere in the system
        private int _manga;
        private int _problemsheets;
        private int _lightnovel;
        private readonly ISubject _inventoryStock;
        //this class uses the subject interface to populate the variable inventoryStock and register an observer to the subject.
        public CurrentInventoryDisplay(ISubject inventoryStock)
        {
            _inventoryStock = inventoryStock;
            _inventoryStock.RegisterObserver(this);
        }
        //the display method will print out predetermined text along with the most recently observed inventory levels from the subject.
        public void Display()
        {
            Console.WriteLine("Current Manga stock is: " + _manga + " Current Problem sheet stock is: " + _problemsheets + " Current lightnovel stock is: " + _lightnovel);
        }
        //The update method will when called populate the fields with the current observed values before calling the display method (see line 25).
        public void Update(int manga, int problemsheets, int lightnovel)
        {
            _manga = manga;
            _problemsheets = problemsheets;
            _lightnovel = lightnovel;
            Display();
        }
    }
}

