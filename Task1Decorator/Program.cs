using System;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator
{
        public class Program
        {
            public static void Main(string[] args)
            {
            /*create new instance of a class using both the motherboard abstract and the properties of the Asus_ROG_Crosshair class */ 
                Motherboard purchase = new ASUS_ROG_Crosshair();
            /* use the console to display both the description and price of the motherboard alone */
                Console.WriteLine(purchase.Description + " final price is " + " £" + purchase.Cost());

            /*create new instance of a class using both the motherboard abstract and the properties of the Asus_ROG_Maximus class */
            Motherboard purchase2 = new ASUS_ROG_Maximus();
            /* add decorators to the newly created instance. For the test one of each decorator has been added */
                purchase2 = new CPU(purchase2);
                purchase2 = new RAM(purchase2);
                purchase2 = new Fan(purchase2);
            /* use the console to display the description & cost of the motherboard and append this with the description & price of each of the decorator classes*/
                Console.WriteLine(purchase2.Description + " final price is " + " £" + purchase2.Cost());

            /*create new instance of a class using both the motherboard abstract and the properties of the Asus_ROG_Strix class */
            Motherboard purchase3 = new ASUS_ROG_Strix();
            /* add decorators to the newly created instance. For the test only one decorator has been added */
            purchase3 = new CPU(purchase3);
            /* use the console to display the description & cost of the motherboard and append this with the description & price of each of the decorator classes*/
            Console.WriteLine(purchase3.Description  + " final price is " + " £" + purchase3.Cost());

            }
        }
    }

