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

   
        public Vehicle VehicleGenerator(int VehicaleType)
        {
            Random random = new Random();
            VehicleInfo vehicleInfo = new VehicleInfo();

            string vehicleReg = VehicleRegistration();
            int rnd = random.Next(0, 17);
            string color = vehicleInfo.colors[rnd];

            switch (VehicaleType)
            {
                case 0:
                    {
                        bool electricCar = random.Next(0, 2) == 0 ? false : true;
                        Car car = new Car(vehicleReg, color, electricCar);
                        return car;
                    }
                case 1:
                    {
                        rnd = random.Next(0, 16);
                        string brand = vehicleInfo.motorcycleBrands[rnd];
                        Motorcycle mc = new Motorcycle(vehicleReg, color, brand);
                        return mc;
                    }
                case 2:
                    {
                        int people = random.Next(15, 46);
                        Bus bus = new Bus(vehicleReg, color, people);
                        return bus;
                    }                 
            }
            return null;
        }



        public Car CarGenerator()
        {
            Random random = new Random();
            VehicleInfo vehicleInfo = new VehicleInfo();

            string vehicleReg = VehicleRegistration();
            int rnd = random.Next(0, 17);
            string color = vehicleInfo.colors[rnd];
            bool electricCar = random.Next(0, 2) == 0 ? false : true;

            Car car = new Car(vehicleReg, color, electricCar);
            return car;
        }

        public Motorcycle McGenerator()
        {
            Random random = new Random();
            VehicleInfo vehicleInfo = new VehicleInfo();

            string vehicleReg = VehicleRegistration();
            int rnd = random.Next(0, 17);
            string color = vehicleInfo.colors[rnd];
            rnd = random.Next(0, 16);
            string brand = vehicleInfo.motorcycleBrands[rnd];

            Motorcycle mc = new Motorcycle(vehicleReg, color, brand);
            return mc;
        }

        public Bus BusGenerator()
        {
            Random random = new Random();
            VehicleInfo vehicleInfo = new VehicleInfo();

            string vehicleReg = VehicleRegistration();
            int rnd = random.Next(0, 17);
            string color = vehicleInfo.colors[rnd];
            int people = random.Next(15, 46);

            Bus bus = new Bus(vehicleReg, color, people);
            return bus;
        }



    }
}
