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

        public void FuelNeeded(int distanceLand, int distanceSea, int people)
        {
            var newDistance = Move(distanceLand) + Swim(distanceSea);

            if (people % Capacity == 0)
                newDistance *= (((people / Capacity) * 2) - 1);
            else
                newDistance *= ((((people / Capacity) + 1) * 2) - 1);

            FuelSpent = ((newDistance / 100) * FuelConsumption);
        }
    }
}
