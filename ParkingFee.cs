using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class ParkingFee
    {
        public int TimeStayed { get; set; } = 0;
        public double FeeAmount { get; set; } = 0;



        public static double FeeCounter(ParkingSpace[] garage)
        {
            double revenueMinute = 0;

            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].IsOccupied)
                {
                    if (garage[i].Vehicles.Count > 1)
                    {
                        garage[i].Vehicles[0].FeeInfo.TimeStayed++;
                        garage[i].Vehicles[1].FeeInfo.TimeStayed++;
                        garage[i].Vehicles[0].FeeInfo.FeeAmount += 1.5;
                        garage[i].Vehicles[1].FeeInfo.FeeAmount += 1.5;
                        revenueMinute += 3;
                    }

                    else if (garage[i].Vehicles[0].VehicleType == 3)
                    {
                        garage[i].Vehicles[0].FeeInfo.TimeStayed++;
                        garage[i].Vehicles[0].FeeInfo.FeeAmount += 1.5;
                        revenueMinute += 1.5;
                        i++;
                    }

                    else
                    {
                        garage[i].Vehicles[0].FeeInfo.TimeStayed++;
                        garage[i].Vehicles[0].FeeInfo.FeeAmount += 1.5;
                        revenueMinute += 1.5;
                    }
                }
            }
            return revenueMinute;
        }    
    }
}
