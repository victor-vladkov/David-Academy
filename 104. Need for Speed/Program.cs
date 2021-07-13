using System;

namespace _104._Need_for_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
            this.defaultFuelConsumption = 1.25;
        }
        public double Fuel {get; set;}
        public int HorsePower {get; set;}
        public double DefaultFuelConsumption {get; set;}
        public virtual double FuelConsumption {get; set;}
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.DefaultFuelConsumption;
		}
    }
    public class MotorCycle:Vehicle
    {
        public MotorCycle(int horsePower, double fuel):base(horsePower, fuel)
        {}
    }
    public class RaceMotorcycle:MotorCycle
    {
        public RaceMotorcycle(int horsePower, double fuel):base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 8;
        }
    }
    public class CrossMotorCycle:MotorCycle
    {
        public CrossMotorCycle(int horsePower, double fuel):base(horsePower, fuel)
        {}
    }
    public class Car:Vehicle
    {
        public Car(int horsePower, double fuel):base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 3;
        }
    }
    public class SportCar:Car
    {
        public SportCar(int horsePower, double fuel):base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 10;
        }
    }
    public class FamilyCar:Car
    {
        public FamilyCar(int horsePower, double fuel):base(horsePower, fuel)
        {}
    }
}

