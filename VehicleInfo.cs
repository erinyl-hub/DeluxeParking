using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class VehicleInfo
    {
        public string[] colors { get; } = {
            "Red", "Blue", "Green", "Yellow", "Black",
            "White", "Gray", "Orange", "Purple",
            "Pink", "Brown", "Turquoise", "Magenta",
            "Beige", "Gold", "Silver", "Navy Blue"
        };

        public string[] motorcycleBrands { get; } = {
            "Harley-Davidson", "Yamaha", "Honda", "Kawasaki",
            "Ducati", "BMW", "Suzuki", "Triumph",
            "KTM", "Aprilia", "Indian", "MV Agusta",
            "Royal Enfield", "Moto Guzzi", "Husqvarna", "Benelli"
        };
    }
}
