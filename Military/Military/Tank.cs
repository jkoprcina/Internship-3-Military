using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public sealed class Tank : Vehicle, IDriveable
    {
        Random rnd = new Random();
        public Tank(int id, int weight, int averageSpeed)
            : base(id, weight, averageSpeed)
        {
            base.Capacity = 6;
            base.FuelConsumption = 30;
        }

        public override string Output()
        {
            return base.Output() + $"Fuel spent {FuelSpent}";
        }

        public int Move(int distance)
        {
            var newDistance = distance;
            while (newDistance - 10 > 0)
            {
                if (rnd.Next(10) < 3)
                {
                    distance += 5;
                    newDistance += 5;
                }
                newDistance -= 10;
            }
            return distance;
        }

        public void FuelNeeded(int distance, int people)
        {
            var newDistance = Move(distance);

            if (people % Capacity == 0)
                newDistance *= (((people / Capacity) * 2) - 1);
            else
                newDistance *= ((((people / Capacity) + 1) * 2) - 1);

            FuelSpent = ((newDistance / 100) * FuelConsumption);
            Console.WriteLine(FuelSpent);
        }
    }
}
