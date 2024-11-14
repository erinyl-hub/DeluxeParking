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
            double revenuePerMinute = 0;


            while (true)
            {

                MsgOut.FeePerMinMsg(revenuePerMinute);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                int switchChoise = keyInfo.KeyChar - '0';
                int[] parkingSpotValues;
                TheFactory theFactory = new TheFactory();
                Vehicle vehicle = theFactory.VehicleGenerator();
                bool fulGarage = false;


                switch (switchChoise)
                {
                    case 1:
                        {
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
                                        fulGarage = true;
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
                                    fulGarage = true;
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
                                    fulGarage = true;
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


                        Console.WriteLine("Wrong Input...");
                        break;
                }
                revenuePerMinute = ParkingFee.FeeCounter(garage);
                Console.Clear();
                if (fulGarage) { MsgOut.NoSpaceMsg(vehicle); }
                MsgOut.OutMsg(garage);


            }



        }


    }


}

