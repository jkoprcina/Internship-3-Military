using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public sealed class Warship : Vehicle
    {
        Random rnd = new Random();
        public Warship(int id, int weight, int averageSpeed)
            : base(id, weight, averageSpeed)
        {
            Capacity = 50;
            FuelConsumption = 200;
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

        public void FuelNeeded(int distance, int people)
        {
            distance = Swim(distance);
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
