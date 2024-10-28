using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeluxeParking
{
    internal class TheGears
    {
        public string VehicleRegistration()
        {
            string vehicleReg = LetterGenerator();
            vehicleReg = vehicleReg + NumberGenerator();
            return vehicleReg;
        }

        public string LetterGenerator()
        {
            string regLetters = "";
            
            for (int i = 0; i < 3; i++)
            {
                int letterIndex = Random.Shared.Next(0, 26);
                char letter = (char)('A' + letterIndex);
                regLetters = regLetters + letter;
            }         
            return regLetters;
        }

        public string NumberGenerator()
        {
            string regNumber = "";
            
            for (int i = 0; i < 3; i++) 
            {
                int number = Random.Shared.Next(0, 10);
                regNumber = regNumber + number;
            }
            return regNumber;
        }

    }
}
