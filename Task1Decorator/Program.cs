using System;
using Task1Decorator.Components;
using Task1Decorator.Decorators;

namespace Task1Decorator
{
        public class Program
        {
            public static void Main(string[] args)
            {
                Motherboard purchase = new ASUS_ROG_Crosshair();
                Console.WriteLine(purchase.Description + " $" + purchase.Cost());

                Motherboard purchase2 = new ASUS_ROG_Maximus();
                purchase2 = new CPU(purchase2);
                purchase2 = new RAM(purchase2);
                purchase2 = new Fan(purchase2);
                Console.WriteLine(purchase2.Description + " $" + purchase2.Cost());

                Motherboard purchase3 = new ASUS_ROG_Strix();
                purchase3 = new RAM(purchase3);
                purchase3 = new CPU(purchase3);
                purchase3 = new Fan(purchase3);
                Console.WriteLine(purchase3.Description + " $" + purchase3.Cost());
            }
        }
    }

