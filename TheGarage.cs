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
                            TheFactory theFactory = new TheFactory();
                            Vehicle vehicle = theFactory.VehicleGenerator();



                            string input = Console.ReadLine();

                            int amount = int.Parse(input);




                            garage[amount].Vehicles.Add(vehicle);





                            break;
                        }
                    case 2:
                        {
                            /*int[] */parkingSpotValues = OptimalParking.OptimalParkingOne(garage);



                            Console.Clear();
                            for (int i = 0; i < garage.Length; i++)
                            {

                                if (garage[i].IsOccupied == true)
                                {
                                    Console.WriteLine(garage[i].Vehicles[0].RegistryNumber + " | " + parkingSpotValues[i]);
                                }
                                else
                                {
                                    Console.WriteLine("Tomt   |    " + parkingSpotValues[i]);
                                }


                            }


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
