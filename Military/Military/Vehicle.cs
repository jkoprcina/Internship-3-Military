using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Military
{
    public abstract class Vehicle
    {
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

        public Vehicle()
        {
        }

        public virtual void Output()
        {

        }
    }
}
