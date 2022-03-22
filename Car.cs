using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car:Vehicle
    {
        public override int FuelCapacity { get; set; }
        public override int CurrentFuel { get; set; }
        public override int FuelFor1km { get; set; }

        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public override string ShowInfo()
        {
            return $"Color: {this.Color} - BrandName: {this.BrandName} - Millage: {this.Millage}";
        }
            


    }
}
