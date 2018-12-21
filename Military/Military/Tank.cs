using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public sealed class Tank : Vehicle
    {
        Random rnd = new Random();
        public Tank(int id, int weight, int averageSpeed)
            : base(id, weight, averageSpeed)
        {
            Capacity = 6;
            FuelConsumption = 30;
        }

        public override string Output()
        {
            return base.Output() + $"Fuel spent {FuelSpent}";
        }

        public int Move(int distance)
        {
            var possibleAccidents = distance / 10;
            for (int i = 0; i < possibleAccidents; i++)
            {
                if (rnd.Next(10) < 3)
                {
                    distance += 5;
                }
            }
            return distance;
        }

        public void FuelNeeded(int distance, int people)
        {
            distance = Move(distance);
            var newDistance = 0;

            if (people % Capacity == 0)
                newDistance *= ((people / Capacity) * 2);
            else
                newDistance *= (((people / Capacity) + 1) * 2);

            newDistance -= distance;

            FuelSpent = newDistance * FuelConsumption;
        }
    }
}
