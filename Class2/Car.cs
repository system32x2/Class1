using System;
using System.Collections.Generic;
using System.Text;

namespace Class2
{
    internal class Car
    {
        public string plate { get; set; }
        public string manufactor { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public double price { get; set; }
        public string chipset { get; set; }

        public Car()
        {

        }

        public Car(string Plate, string Manufactor, string Model, string Brand, double Price, string Chipset)
        {
            Manufactor = manufactor;
            Plate = plate;
            Model = model;
            Brand = brand;
            Price = price;
            Chipset = chipset;
        }
        public override string ToString()
        {
            return $"{manufactor} {model}-{brand} {price} ({plate}   {chipset})";
        }
    }
}
