using System;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting up the vars and objects we'll use
            var tank = new Tank(0, 2000, 40);
            var warship = new Warship(0, 200000, 50);
            var amfibia = new Amfibia(0, 3000, 30);
            var success = false;
            var tankDistance = 0;
            var warshipDistance = 0;
            var amfibijLandDistance = 0;
            var amfibijWaterDistance = 0;
            var soldiers = 0;

            //asking the user to input some information that we need
            Console.WriteLine("Enter the minimum required distance, in km, that the three vehicle types need to pass to get from point A to point B");
            do
            {
                Console.WriteLine("Enter the distance a tank needs to pass");
                success = int.TryParse(Console.ReadLine(), out tankDistance);
                if (success == false)
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (success != true);

            do
            {
                Console.WriteLine("Enter the distance a warship needs to pass");
                success = int.TryParse(Console.ReadLine(), out warshipDistance);
                if (success == false)
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (success != true);

            do
            {
                Console.WriteLine("Enter the distance a amfibij needs to pass by land");
                success = int.TryParse(Console.ReadLine(), out amfibijLandDistance);
                if (success == false)
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (success != true);

            do
            {
                Console.WriteLine("Enter the distance a tank needs to pass by water");
                success = int.TryParse(Console.ReadLine(), out amfibijWaterDistance);
                if (success == false)
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (success != true);
            do
            {
                Console.WriteLine("Enter the number of soldiers that need to be transported");
                success = int.TryParse(Console.ReadLine(), out soldiers);
                if (success == false)
                {
                    Console.WriteLine("Wrong input, try again");
                }
            } while (success != true);

            tank.FuelNeeded(tankDistance, soldiers);
            warship.FuelNeeded(warshipDistance, soldiers);
            amfibia.FuelNeeded(amfibijLandDistance, amfibijWaterDistance, soldiers);

            tank.Output();
            warship.Output();
            amfibia.Output();
        }
    }
}
