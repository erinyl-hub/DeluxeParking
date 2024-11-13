using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal abstract class Vehicle
    {
        public string RegistryNumber { get; set; }
        public string VehicleColor { get; set; }
        public virtual int VehicleType { get; set; }

        public Vehicle(string registryNumber, string vehicleColor)
        {
            RegistryNumber = registryNumber;
            VehicleColor = vehicleColor;
            
        }

    }

    internal class Car : Vehicle
    {
        public bool ElectricCar { get; set; }
        public override int VehicleType { get; set; } = 1;

        public Car(string registryNumber, string vehicleColor, bool electricCar) : base(registryNumber, vehicleColor)
        {
            ElectricCar = electricCar;
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }
        public override int VehicleType { get; set; } = 2;


        public Motorcycle(string registryNumber, string vehicleColor, string brand) : base(registryNumber, vehicleColor)
        {
            Brand = brand;
        }
    }

    internal class Bus : Vehicle
    {
        public int Passengers { get; set; }
        public override int VehicleType { get; set; } = 3;


        public Bus(string registryNumber, string vehicleColor, int passengers) : base(registryNumber, vehicleColor)
        {
            Passengers = passengers;
        }
    }
}


