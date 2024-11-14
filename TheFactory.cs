using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class TheFactory
    {
        private string VehicleRegistration()
        {
            string vehicleReg = LetterGenerator();
            vehicleReg = vehicleReg + NumberGenerator();
            return vehicleReg;
        }

        private string LetterGenerator()
        {
            string regLetters = "";

            for (int i = 0; i < 3; i++)
            {
                int letterIndex = Random.Shared.Next(0, 26);
                char letter = (char)('A' + letterIndex);
                regLetters = regLetters + letter;
            }
            return regLetters;
        }

        private string NumberGenerator()
        {
            string regNumber = "";

            for (int i = 0; i < 3; i++)
            {
                int number = Random.Shared.Next(0, 10);
                regNumber = regNumber + number;
            }
            return regNumber;
        }

   
        public Vehicle VehicleGenerator()
        {
            Random random = new Random();
            int VehicaleType = random.Next(0, 3);
            VehicleInfo vehicleInfo = new VehicleInfo();

            string vehicleReg = VehicleRegistration();
            int rnd = random.Next(0, 17);
            string color = vehicleInfo.colors[rnd];
            
            switch (VehicaleType)
            {
                case 0:
                    {
                        bool electricCar = random.Next(0, 2) == 0 ? false : true;
                        Car car = new Car(vehicleReg, color, electricCar);
                        return car;
                    }
                case 1:
                    {
                        rnd = random.Next(0, 16);
                        string brand = vehicleInfo.motorcycleBrands[rnd];
                        Motorcycle mc = new Motorcycle(vehicleReg, color, brand);
                        return mc;
                    }
                case 2:
                    {
                        int people = random.Next(15, 46);
                        Bus bus = new Bus(vehicleReg, color, people);
                        return bus;
                    }                 
            }
            return null;
        }

        public static void RemoveVehicle(ParkingSpace[] garage)
        {
            Console.WriteLine();
            Console.Write("Enter registration number of vehicle to remove: ");
            string remove = Console.ReadLine();

            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].IsOccupied)
                {
                    if (garage[i].Vehicles[0].RegistryNumber == remove && garage[i].Vehicles[0].VehicleType == 3)
                    {
                        Console.WriteLine("Vehicle " + garage[i].Vehicles[0].RegistryNumber + " will be removed");
                        garage[i].Vehicles.RemoveAt(0);
                        garage[(i+1)].Vehicles.RemoveAt(0);
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey();
                    }

                    else if (garage[i].Vehicles[0].RegistryNumber == remove)
                    {
                        Console.WriteLine("Vehicle " + garage[i].Vehicles[0].RegistryNumber + " will be removed");
                        garage[i].Vehicles.RemoveAt(0);
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey();
                    }

                    else if (garage[i].Vehicles.Count > 1 && garage[i].Vehicles[1].RegistryNumber == remove)
                    {
                        Console.WriteLine("Vehicle " + garage[i].Vehicles[1].RegistryNumber + " will be removed");
                        garage[i].Vehicles.RemoveAt(1);
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }    
    }
}
