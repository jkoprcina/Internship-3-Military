using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public sealed class Amfibia : Vehicle
    {
        Random rnd = new Random();
        public Amfibia(int id, int weight, int averageSpeed)
            : base(id, weight, averageSpeed)
        {
            Capacity = 20;
            FuelConsumption = 70;
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

        public int Swim(int distance)
        {
            var time = Calcuator.minutesTime(distance, AverageSpeed);
            var possibleAccidents = time / 10;

            for (int i = 0; i < possibleAccidents; i++)
            {
                if (rnd.Next(10) < 5)
                {
                    distance += 3;
                }
            }
            return distance;
        }

        public void FuelNeeded(int distanceLand, int distanceWater, int people)
        {
            var distance = Move(distanceLand) + Swim(distanceWater);
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
