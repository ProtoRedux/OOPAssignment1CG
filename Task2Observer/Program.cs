using System;
using Task2Observer.Observers;
using Task2Observer.Subjects;

namespace Task2Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //generates a new inventory object from inventory class called inventory list.
            Inventory inventoryList = new Inventory();

            //generates a new inventory deispaly object using the generated inventory list object.
            CurrentInventoryDisplay CurrentInventory = new CurrentInventoryDisplay(inventoryList);

            //for the purposes of testing, three differant inventory levels for three items have been hardcoded below.
            //for the first test, manga has a value of 80 on hand, problem sheets a value of 65 and lightnovels 30.
            inventoryList.SetInventoryLevels(80, 65, 30);
            //to confirm the observers are notified of anychange and update correctly the values are shifted.
            inventoryList.SetInventoryLevels(42, 55, 29);
            //this was completed one final time to ensure updates occured.
            inventoryList.SetInventoryLevels(90, 90, 19);
        }
    }
}

