﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tutorial
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman!";
            superman.value = "Clark Kent!";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "a 50 in Samsung TV";

            superman.showData();

            samsungTV.showData();


        }
    }

    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() : base()
        {
            this.favFood = "No favorite food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base
            (height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}",
                name, height, weight, sound, favFood);

        }
    }

    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    public interface ShapeItem
    {
        double area();
    }

    class Rectangle : Shape
    {

        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }


    }

    class Triangle : Shape
    {

        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }

    }

    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1} ", this.key, this.value);
        }
    }

}
