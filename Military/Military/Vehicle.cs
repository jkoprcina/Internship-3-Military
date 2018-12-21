using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Military
{
    public abstract class Vehicle
    {
        public int FuelSpent;

        private int _Id;
        private int _Weight;
        private int _AverageSpeed;
        private int _FuelConsumption;
        private int _Capacity;

        public int Id { get => Id; set => _Id = value; }
        public int Weight { get => Weight; set => _Weight = value; }
        public int AverageSpeed { get => AverageSpeed; set => _AverageSpeed = value; }
        public int FuelConsumption { get => FuelConsumption; set => _FuelConsumption = value; }
        public int Capacity { get => Capacity; set => _Capacity = value; }

        public Vehicle(int id, int weight, int averageSpeed)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public virtual string Output()
        {
            return $"Tank info: " +
                   $"ID: {Id}" +
                   $"Weight: {Weight}" +
                   $"Average speed: {AverageSpeed}" +
                   $"Fuel usage: {FuelConsumption}" +
                   $"Capacity: {Capacity}";
        }
    }
}
