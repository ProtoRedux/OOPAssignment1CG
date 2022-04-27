using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Observer.Observers;

namespace Task2Observer.Subjects
{
    //creates an interface for observation subjects (see inventory class).
    public interface ISubject
    {
        //any object with this interface attached can use the following methods to add, remove or notify observers of changes that occur within the object
        //see inventory class line 36
        void RegisterObserver(IObserver o);
        //see inventory class line 52
        void RemoveObserver(IObserver o);
        //see inventory class line 39 - 43
        void NotifyObservers();
    }
}

