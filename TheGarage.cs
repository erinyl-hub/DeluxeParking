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
            ParkingSpace[] garage = new ParkingSpace[15];

            ParkingSpace.GenerateParking(garage);

            while (true)
            {
                Console.WriteLine("Meny Val:");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                int switchChoise = keyInfo.KeyChar - '0';
                int[] parkingSpotValues;

                switch (switchChoise)
                {
                    case 1:
                        {
                            int vehicleCount = 0;
                            TheFactory theFactory = new TheFactory();
                            Vehicle vehicle = theFactory.VehicleGenerator();




                            
                            
                                Type type = vehicle.GetType();

                                if (type == typeof(Motorcycle))
                                {
                                    if (OptimalParking.DoubleParkMc(garage, vehicle))
                                    {
                                        parkingSpotValues = OptimalParking.OptimalParkingOne(garage);
                                        garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                        vehicleCount++;
                                    }
                                }

                                else if (type == typeof(Car))
                                {
                                    parkingSpotValues = OptimalParking.OptimalParkingOne(garage);
                                    garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                    vehicleCount++;
                                }

                                else if (type == typeof(Bus))
                                {
                                    parkingSpotValues = OptimalParking.OptimalParkingTwo(garage);
                                    garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                    garage[OptimalParking.TheParker(parkingSpotValues) + 1].Vehicles.Add(vehicle);
                                    vehicleCount++;
                                }
                            







                            break;
                        }
                    case 2:
                        {
                            /*int[] */



                            Console.Clear();

                            MsgOut.OutMsg(garage);

                            //for (int i = 0; i < garage.Length; i++)
                            //{

                            //    if (garage[i].IsOccupied == true)
                            //    {
                            //        Console.WriteLine(i + " | " +  garage[i].Vehicles[0].RegistryNumber + " | " /*+ parkingSpotValues[i]*/);
                            //        Console.WriteLine(i + " | " + garage[i].Vehicles.Count + " | " /*+ parkingSpotValues[i]*/);
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Tomt   |    " /*+ parkingSpotValues[i]*/);
                            //    }


                            //}


                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            for (int i = 0; i < garage.Length; i++)
                            {

                                if (garage[i].IsOccupied == true)
                                {
                                    Console.WriteLine(garage[i].Vehicles[0].RegistryNumber + " | ");
                                }
                                else
                                {
                                    Console.WriteLine("Tomt");
                                }


                            }

                            Console.WriteLine("övrigt:");
                            break;
                        }
                }



            }


        }


    }
}
