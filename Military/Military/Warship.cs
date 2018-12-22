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
            while (time - 10 > 0)
            {
                if (rnd.Next(10) < 5)
                {
                    distance += 3;
                    time += Calcuator.minutesTime(3, AverageSpeed);
                }
            }
            return distance;
        }

        public void FuelNeeded(int distance, int people)
        {
            var newDistance = Swim(distance);

            if (people % Capacity == 0)
                newDistance *= (((people / Capacity) * 2) - 1);
            else
                newDistance *= ((((people / Capacity) + 1) * 2) - 1);

            FuelSpent = ((newDistance / 100) * FuelConsumption);
        }
    }
}
