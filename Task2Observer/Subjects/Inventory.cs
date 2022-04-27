using System.Collections.Generic;
using Task2Observer.Observers;

namespace Task2Observer.Subjects
{
    //this creates a class to hold inventory data with a subject interface as it is the data here that is to be monitored by the observers. 
    public class Inventory : ISubject
    {
        //readonly lists for all observer interfaces are created so they cannot be manipulated by other facets of the program
        private readonly List<IObserver> _observers;
        //private fields for the item variables are made here for the same reason. 
        private int _manga;
        private int _problemsheet;
        private int _lightnovel;

        public Inventory()
        {
            //the inventory class will generate a new list of observers
            _observers = new List<IObserver>();
        }

        //A method created to notify all observers when stock inventory changes in some way. 
        public void StockInventoryChanged()
        {
            //see line 36.
            NotifyObservers();
        }
        //This method using the item variables given in the main program convert the values into private ints and calls the method StockInventoryChanged (see line 22).
        public void SetInventoryLevels(int manga, int problemsheet, int lightnovel)
        {
            _manga = manga;
            _problemsheet = problemsheet;
            _lightnovel = lightnovel;
            StockInventoryChanged();
        }
        //This method is to notify observers when a change occurs in the values in the SetInventoryLevels method
        public void NotifyObservers()
        {
            //for every instance of an observer found in the list created on line 19 
            foreach (var observer in _observers)
            {
                // run the update method for each readonly value on all observers
                observer.Update(_manga, _problemsheet, _lightnovel);
            }
        }
        //method to register observers (anything with the observer interface).
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        //method to remove any previously registered observers
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}
