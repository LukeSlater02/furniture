using System;

namespace furniture
{
    class DiningTable : Furniture, ITable
    {
        public int Legs {get;set;}

        public int Length {get;set;}
    }
}