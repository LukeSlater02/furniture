using System;

namespace furniture
{
    class Nightstand : Furniture, ITable
    {
        public bool hasLamp {get;set;}

        public int Drawers {get;set;}

        public int Legs {get;set;}

        public int Length {get;set;}
    }
}