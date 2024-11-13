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

        public static void OutMsg(ParkingSpace[] garage)
        {
            for (int i = 0; i < garage.Length; i++)
            {          

                if (garage[i].Vehicles.Count != 0)
                {
                    Vehicle vehicle = garage[i].Vehicles[0];

                    if (vehicle is Car)
                    {
                        Car car = (Car)vehicle;

                        Console.WriteLine("Plats [ " + (i+1) + " ] Bil     -      " + car.RegistryNumber +
                            "    -    " + car.VehicleColor + "  -  " + (car.ElectricCar == true ? "Elbil" : "Bensinbil"));

                    }
                    else if (vehicle is Motorcycle)
                    {
                        Motorcycle mc = (Motorcycle)vehicle;

                        if (garage[i].Vehicles.Count > 1)
                        {
                            Console.WriteLine("Plats [ " + (i + 1) + " ] MCykel  -      " + mc.RegistryNumber +
                                "    -    " + mc.VehicleColor + "  -  " + mc.Brand);

                            Vehicle mcCast = garage[i].Vehicles[1];

                            Motorcycle mcTwo = (Motorcycle)mcCast;

                            Console.WriteLine("Plats [ " + (i + 1) + " ] MCykel  -      " + mcTwo.RegistryNumber +
                                "    -    " + mcTwo.VehicleColor + "  -  " + mcTwo.Brand);
                        }

                        else
                        {
                            Console.WriteLine("Plats [ " + (i + 1) + " ] MCykel  -      " + mc.RegistryNumber +
                                "    -    " + mc.VehicleColor + "  -  " + mc.Brand);
                        }
                    }
                    else if (vehicle is Bus)
                    {
                        Bus bus = (Bus)vehicle;

                        Console.WriteLine("Plats [" + (i + 1) + "/" + (i + 2) + "] Buss    -      " + bus.RegistryNumber + "    -    " + bus.VehicleColor + "  -  " + bus.Passengers);
                        i++;
                    }
                }

                else
                {
                    Console.WriteLine("Plats [ " + (i + 1) + " ] Tom");
                }
            }
        }
    }
}
