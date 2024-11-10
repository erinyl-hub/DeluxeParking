using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class TheGarage
    {


        public static void RunGarage()
        {
            string[] garage = new string[15];
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                Console.WriteLine("Meny Val:");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                int switchChoise = keyInfo.KeyChar - '0';

                switch (switchChoise)
                {
                    case 1:
                        {
                            TheFactory theFactory = new TheFactory();
                            Vehicle vehicle = theFactory.VehicleGenerator();



                            vehicles.Add(vehicle);

                            Console.WriteLine("Plats i garaget?");

                            keyInfo = Console.ReadKey(true);
                            switchChoise = keyInfo.KeyChar - '0';

                            garage[switchChoise] = vehicle.RegistryNumber;


                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("case 2:");

                            keyInfo = Console.ReadKey(true);
                            switchChoise = keyInfo.KeyChar - '0';


                            for (int i = 0; i < garage.Length; i++)
                            {
                                if (garage[i] == null)
                                {
                                    Console.WriteLine("Parkeringsplats " + (i + 1) + ": Tom");
                                }
                                
                                for (int j = 0; j < vehicles.Count; j++)
                                {
                                    if (vehicles[j].RegistryNumber == garage[i])
                                    {









                                    }
                                }



                               
                            }
                            Console.WriteLine("___________________________________");





                            //Vehicle vehicle = garage[switchChoise];
                            //Console.WriteLine("Typ: " + vehicle.GetType + " Reg nummer: " + vehicle.RegistryNumber + " Färg: " + vehicle.VehicleColor);



                            foreach (Vehicle vehicle in vehicles)
                            {

                                Type getType = vehicle.GetType();

                                if (getType == typeof(Car))
                                {
                                    Car car = (Car) vehicle;
                                    Console.WriteLine("Bil " + " Reg nummer: " + car.RegistryNumber + " Färg: " + car.VehicleColor);
                                }

                                else if (getType == typeof(Motorcycle))
                                {
                                    Motorcycle motorcycle = (Motorcycle) vehicle;
                                    Console.WriteLine("MC " + " Reg nummer: " + motorcycle.RegistryNumber + " Färg: " + motorcycle.VehicleColor);

                                }
                                else
                                {
                                    Bus bus = (Bus) vehicle;
                                    Console.WriteLine("Buss " + " Reg nummer: " + bus.RegistryNumber + " Färg: " + bus.VehicleColor);

                                }

                            }





                            break;
                        }
                    default:
                        {
                            Console.WriteLine("övrigt:");
                            break;
                        }
                }



            }


        }


    }
}
