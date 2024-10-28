using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class Vehicle
    {
        public string RegistryNumber { get; set; }
        public string VehicleColor { get; set; }

        public Vehicle(string registryNumber, string vehicleColor)
        {
            RegistryNumber = registryNumber;
            VehicleColor = vehicleColor;
        }
    }

    internal class Car : Vehicle
    {
        public bool ElectricCar { get; set; }

        public Car(string registryNumber, string vehicleColor, bool electricCar) : base(registryNumber, vehicleColor)
        {
            ElectricCar = electricCar;
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }

        public Motorcycle(string registryNumber, string vehicleColor, string brand) : base(registryNumber, vehicleColor)
        {
            Brand = brand;
        }
    }

    internal class Bus : Vehicle
    {
        public int Passengers { get; set; }

        public Bus(string registryNumber, string vehicleColor, int passengers) : base(registryNumber, vehicleColor)
        {
            Passengers = passengers;
        }
    }
}


