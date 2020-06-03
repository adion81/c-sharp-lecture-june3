using System;

namespace LectureDayThree.Models
{
    public class Dinosaur
    {
        public int Height;
        public string Name;
        public string Type;
        public bool HasFeathers;

        protected int age;

        public int Age
        {
            get
            {
                return age;
            }
        }

        public Dinosaur(string name, string type, int height, bool hasFeathers)
        {
            Name = name;
            Type = type;
            Height = height;
            HasFeathers = hasFeathers;
            age = 1;
        }

        public virtual Dinosaur Birthday()
        {
            age ++;
            System.Console.WriteLine($"Happy Birthday, {Name}!!! You're now {Age} years old.");
            return this;
        }
    }
}