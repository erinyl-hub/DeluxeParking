namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] vehicles = new Vehicle[14];
            TheGears theGears = new TheGears();

            

            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = theGears.VehicleGenerator(1);

                vehicles[i] = vehicle;
            }


            Console.ReadLine();

        }
    }
}
