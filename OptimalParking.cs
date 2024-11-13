using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class OptimalParking
    {
        public static int[] OptimalParkingOne(ParkingSpace[] garage)
        {
            int[] result = new int[15];

            for (int i = 0; i < garage.Length; i++)
            {
                string parkingCode = "";

                if (garage[i].IsOccupied == false)
                {
                    if (i == 0)
                    {
                        parkingCode = "00";

                        parkingCode += ReturnNumber(garage, (i + 1));
                        parkingCode += ReturnNumber(garage, (i + 2));

                    }

                    else if (i == 1)
                    {
                        parkingCode = "0";

                        parkingCode += ReturnNumber(garage, (i - 1));
                        parkingCode += ReturnNumber(garage, (i + 1));
                        parkingCode += ReturnNumber(garage, (i + 2));

                    }


                    else if (i > 1 && i < 13)
                    {
                        parkingCode += ReturnNumber(garage, (i - 2));
                        parkingCode += ReturnNumber(garage, (i - 1));
                        parkingCode += ReturnNumber(garage, (i + 1));
                        parkingCode += ReturnNumber(garage, (i + 2));

                    }

                    else if (i == 13)
                    {

                        parkingCode += ReturnNumber(garage, (i - 2));
                        parkingCode += ReturnNumber(garage, (i - 1));
                        parkingCode += ReturnNumber(garage, (i + 1));
                        parkingCode += "0";
                    }

                    else if (i == 14)
                    {
                        parkingCode += ReturnNumber(garage, (i - 2));
                        parkingCode += ReturnNumber(garage, (i - 1));
                        parkingCode += "00";
                    }

                    int ParkingSpotValue = ParkingValue(parkingCode);

                    result[i] = ParkingSpotValue;
                }

                else
                {
                    result[i] = 99;
                }
            }

            return result;
        }

        public static string ReturnNumber(ParkingSpace[] garage, int index)
        {
            string parkingCode = "";

            if (garage[index].IsOccupied == false)
            {
                parkingCode += "1";
            }
            else if (garage[index].Vehicles[0].VehicleType == 1 || garage[index].Vehicles[0].VehicleType == 2)
            {
                parkingCode += "2";
            }
            else if (garage[index].Vehicles[0].VehicleType == 3)
            {
                parkingCode += "3";
            }

            return parkingCode;
        }

        public static int ParkingValue(string parkingCode)
        {
            int value = 0;
            SingelParking singelParking = new SingelParking();

            for (int i = 0; i < singelParking.parkingValueSingel.Count; i++)
            {
                for (int j = 0; j < singelParking.parkingValueSingel[i].Count; j++)
                {
                    if (singelParking.parkingValueSingel[i][j] == parkingCode)
                    {
                        return (i + 1);
                    }
                }
            }
            return (value + 888);

        }


        public static int TheParker(int[] ParkingSpotValue)
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = 0; j < ParkingSpotValue.Length; j++)
                {
                    if ((i) == ParkingSpotValue[j])
                    {
                        return (j);
                    }
                }
            }
            return 55;
        }

        public static bool DoubleParkMc(ParkingSpace[] garage, Vehicle vehicle)
        {
            bool park;

            for(int i = 0; i < garage.Length; i++)
            {
                if (garage[i].IsOccupied)
                {
                    if (garage[i].Vehicles.Count < 2 && garage[i].Vehicles[0].VehicleType == 2)
                    {
                        garage[i].Vehicles.Add(vehicle);

                        return false;
                    }
                }                 
            }
            return true;
        }

                 

        }





}

