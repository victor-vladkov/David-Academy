using System;

namespace _105._Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name {get; set;}
        public decimal Price {get; set;}
    }
    public class Beverage:Product
    {
        public Beverage(string name, decimal price, double milliliters):base(name, price)
        {
            this.milliliters = milliliters;
        }
        public double Milliliters {get; set;}
    }
    public class HotBeverage:Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters):base(name, price, milliliters)
        {}
    }
    public class ColdBeverage:Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters):base(name, price, milliliters)
        {}
    }
    public class Coffee:HotBeverage
    {
        public Coffee(string name, decimal price, double milliliters):base(name, 3.50, 50)
        {}
        public double Caffeine {get; set;}
    }
    public class Tea:HotBeverage
	{
		public Tea(string name, decimal price, double milliliters):base(name, price, milliliters)
		{}
	}
    public class Food:Product
    {
        public Food(string name, decimal price, double grams):base(name, price)
        {
            this.grams = grams;
        }
        public double Grams {get; set;}
    }
    public class MainDish:Food
    {
        public MainDish(string name, decimal price, double grams):base(name, price, grams)
        {}
    }
    public class Dessert:Food
    {
        public Dessert(string name, decimal price, double grams, double calories):base(name, price, grams)
        {
            this.calories = calories;
        }
        public double Calories {get; set;}
    }
    public class Starter:Food
    {
        public Starter(string name, decimal price, double grams):base(name, price, grams)
        {}
    }
    public class Soup:Starter
    {
        public Soup(string name, decimal price, double grams)
        {}
    }
    public class Fish:MainDish
    {
        public Fish(string name, decimal price, double grams):base(name, price, 22)
        {}
    }
    public class Cake:Dessert
    {
        public Cake(string name, decimal price, double grams, double calories):base(name, 5, 250, 1000)
        {}
    }
}
