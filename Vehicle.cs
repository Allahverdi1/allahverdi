using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public string Color;
        public string BrandName;
        public int Millage { get; set; }
        public abstract void Drive();
        public abstract string ShowInfo();


    }
}
