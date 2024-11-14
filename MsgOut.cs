using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class MsgOut
    {

        public static void NoSpaceMsg(Vehicle vehicleNoEntry)
        {
            Console.WriteLine();
            Console.Write("There was no availebel space for - ");
            if (vehicleNoEntry is Car)
            {
                Car carNoEntry = (Car)vehicleNoEntry;
                Console.Write("Car  -  " + carNoEntry.RegistryNumber +
                        "  -  " + carNoEntry.VehicleColor + " - " + (carNoEntry.ElectricCar == true ? "Electric Car" : "Gasolin Car"));
            }

            else if (vehicleNoEntry is Motorcycle)
            {
                Motorcycle McNoEntry = (Motorcycle)vehicleNoEntry;
                Console.Write("Motorcycle  -  " + McNoEntry.RegistryNumber +
                        "  -  " + McNoEntry.VehicleColor + " - " + McNoEntry.Brand);
            }

            else if (vehicleNoEntry is Bus)
            {
                Bus busNoEntry = (Bus)vehicleNoEntry;
                Console.Write("Bus  -  " + busNoEntry.RegistryNumber +
                        "  -  " + busNoEntry.VehicleColor + " - " + busNoEntry.Passengers);
            }

            Console.WriteLine();
            Console.WriteLine();


        }



        public static void OutMsg(ParkingSpace[] garage)
        {
            Console.WriteLine();
            Console.WriteLine("ParkingSpaceDelux_EN");
            Console.WriteLine("(1) to bring in new vehicle - (2) to remove vehicle");
            Console.WriteLine();

            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].Vehicles.Count != 0)
                {
                    Vehicle vehicle = garage[i].Vehicles[0];

                    if (vehicle is Car)
                    {
                        Car car = (Car)vehicle;

                        Console.WriteLine("Space [ " + (i + 1) + " ] Car     -      " + car.RegistryNumber +
                            "    -    " + car.VehicleColor + "  -  " + (car.ElectricCar == true ? "Electric Car" : "Gasolin Car"));
                    }

                    else if (vehicle is Motorcycle)
                    {
                        Motorcycle mc = (Motorcycle)vehicle;

                        if (garage[i].Vehicles.Count > 1)
                        {
                            Console.WriteLine("Space [ " + (i + 1) + " ] MCykel  -      " + mc.RegistryNumber +
                                "    -    " + mc.VehicleColor + "  -  " + mc.Brand);

                            Vehicle mcCast = garage[i].Vehicles[1];

                            Motorcycle mcTwo = (Motorcycle)mcCast;

                            Console.WriteLine("Space [ " + (i + 1) + " ] MCykel  -      " + mcTwo.RegistryNumber +
                                "    -    " + mcTwo.VehicleColor + "  -  " + mcTwo.Brand);
                        }

                        else
                        {
                            Console.WriteLine("Space [ " + (i + 1) + " ] MCykel  -      " + mc.RegistryNumber +
                                "    -    " + mc.VehicleColor + "  -  " + mc.Brand);
                        }
                    }

                    else if (vehicle is Bus)
                    {
                        Bus bus = (Bus)vehicle;
                        Console.WriteLine("Space [" + (i + 1) + "/" + (i + 2) + "] Bus    -      " + bus.RegistryNumber + "    -    " + bus.VehicleColor + "  -  " + bus.Passengers);
                        i++;
                    }
                }

                else
                {
                    Console.WriteLine("Space [ " + (i + 1) + " ] Empty");
                }
            }
        }
    }
}
