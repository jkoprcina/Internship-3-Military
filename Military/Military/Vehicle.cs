using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Military
{
    public abstract class Vehicle
    {
        protected Random rnd = new Random();
        public int Id { get; set; }
        public int Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }
        public double FuelSpent { get; set; }

        public Vehicle(int id, int weight, int averageSpeed)
        {
            Id = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
        }

        public virtual string Output()
        {
            return $"Tank info: ID: {Id}, Weight: {Weight}, Average speed: {AverageSpeed}, Fuel usage: {FuelConsumption}, Capacity: {Capacity}, ";
        }
    }
}
