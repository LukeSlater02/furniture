using System;

namespace furniture
{
    class Couch : Furniture, ISeating
    {
        public int Legs { get; set; }
        public int Capacity { get; set; }
        public int ComfyNessLevel { get; set; }
    }
}