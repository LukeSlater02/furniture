using System;

namespace furniture
{
    class Loveseat: Furniture, ISeating
    {
        public int Legs {get;set;}
        public int Capacity {get;set;}
    }
}