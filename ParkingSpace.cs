using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class ParkingSpace
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public bool IsOccupied => Vehicles.Count > 0;


        public static void GenerateParking(ParkingSpace[] garage)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                garage[i] = new ParkingSpace();

            }

        }

    }
}
