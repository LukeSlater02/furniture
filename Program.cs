using System;
using System.Collections.Generic;
namespace furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Couch couch = new Couch()
            {
                Material = "Whatever the fuck couches are made out of",
                Color = "Gray",
                Legs = 4,
                Capacity = 4
            };

            Loveseat loveseat = new Loveseat()
            {
                Material = "Cushions",
                Color = "Red",
                Legs = 4,
                Capacity = 2
            };

            DiningChair diningChair = new DiningChair()
            {
                Material = "Wood",
                Color = "Brown",
                Legs = 2,
                Capacity = 1
            };

            DiningTable diningTable = new DiningTable()
            {
                Material = "Balsa Wood",
                Color = "Brown",
                Legs = 4,
                Length = 6
            };

            Nightstand nightstand = new Nightstand()
            {
                Material = "Whatever the fuck couches are made out of",
                Color = "Gray",
                hasLamp = true,
                Drawers = 2,
                Length = 4
            };

            List<Furniture> furniture = new List<Furniture>()
            {
                couch,
                loveseat,
                diningChair,
                diningTable,
                nightstand
            };

            foreach(var item in furniture)
            {
                if (item is ITable)
                {
                    ITable table = (ITable)item;
                    System.Console.WriteLine($"TABLE is: {table.Length} ft long.");
                }
                
                if (item is ISeating)
                {
                    ISeating seat = (ISeating)item;
                    System.Console.WriteLine($"SEAT has: {seat.Capacity} capacity.");
                }
            }
        }
    }
}
