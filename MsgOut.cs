using System;
using System.Collections.Generic;
using System.Linq;
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


                Vehicle vehicle = garage[i].Vehicles[0];

                if (vehicle is Car)
                {
                    Car car = (Car)vehicle;                 
                    
                    Console.WriteLine("Plats [" + i + "] Bil  -  " + car.RegistryNumber + "   -   " + car.VehicleColor + (car.ElectricCar == true ? "Elbil" : "Bensinbil"));

                }
                else if (vehicle is Motorcycle)
                {
                    Motorcycle car = (Motorcycle)vehicle;

                }
                else if (vehicle is Bus)
                {
                    Bus bus = (Bus)vehicle;

                }


        }



        




    }
}
