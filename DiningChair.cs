using System;

namespace furniture
{
    class DiningChair : Furniture, ISeating
    {
        public int Legs {get;set;}
        public int Capacity {get;set;}
    }
}