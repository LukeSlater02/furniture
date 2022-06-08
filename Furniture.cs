using System;

namespace furniture
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }
    }

    public interface ISeating
    {
        int Legs { get; set; }
        int Capacity { get; set; }

    }

    public interface ITable
    {
        int Legs { get; set; }
        int Length { get; set; }
    }
}