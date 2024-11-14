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
            MsgOut.OutMsg(garage);
            while (true)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                int switchChoise = keyInfo.KeyChar - '0';
                int[] parkingSpotValues;
                Console.Clear();
                MsgOut.OutMsg(garage);

                switch (switchChoise)
                {
                    case 1:
                        {

                            TheFactory theFactory = new TheFactory();
                            Vehicle vehicle = theFactory.VehicleGenerator();

                            Type type = vehicle.GetType();

                            if (type == typeof(Motorcycle))
                            {
                                if (OptimalParking.DoubleParkMc(garage, vehicle))
                                {
                                    parkingSpotValues = OptimalParking.OptimalParkingOne(garage);
                                    if (!OptimalParking.FulHouse(parkingSpotValues, 15))
                                    {
                                        garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Funkar 1");
                                        Console.ReadLine();
                                    }
                                }
                            }

                            else if (type == typeof(Car))
                            {
                                parkingSpotValues = OptimalParking.OptimalParkingOne(garage);
                                if (!OptimalParking.FulHouse(parkingSpotValues, 15))
                                {
                                    garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                }

                                else
                                {
                                    Console.WriteLine("Funkar 2");
                                    Console.ReadLine();
                                }
                            }

                            else if (type == typeof(Bus))
                            {
                                parkingSpotValues = OptimalParking.OptimalParkingTwo(garage);
                                if (!OptimalParking.FulHouse(parkingSpotValues, 14))
                                {
                                    garage[OptimalParking.TheParker(parkingSpotValues)].Vehicles.Add(vehicle);
                                    garage[OptimalParking.TheParker(parkingSpotValues) + 1].Vehicles.Add(vehicle);
                                }
                                else
                                {
                                    Console.WriteLine("Funkar 3");
                                    Console.ReadLine();
                                }
                            }


                            break;
                        }
                    case 2:
                        {

                            TheFactory.RemoveVehicle(garage);

                            break;
                        }
                    default:
                        {

                        }

                        Console.WriteLine("övrigt:");
                        break;
                }

                Console.Clear();
                MsgOut.OutMsg(garage);

            }



        }


    }


}

