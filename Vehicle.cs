using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class Vehicle
    {
        public int RegistryNumber { get; set; }
        public string VehicleColor { get; set; }

        public Vehicle(int registryNumber, string vehicleColor)
        {
            RegistryNumber = registryNumber;
            VehicleColor = vehicleColor;
        }
    }

    internal class Car : Vehicle
    {
        public bool ElectricCar { get; set; }

        public Car(int registryNumber, string vehicleColor, bool electricCar) : base(registryNumber, vehicleColor)
        {
            ElectricCar = electricCar;
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }

        public Motorcycle(int registryNumber, string vehicleColor, string brand) : base(registryNumber, vehicleColor)
        {
            Brand = brand;
        }
    }

    internal class Bus : Vehicle
    {
        public int Passengers { get; set; }

        public Bus(int registryNumber, string vehicleColor, int passengers) : base(registryNumber, vehicleColor)
        {
            Passengers = passengers;
        }
    }
}


