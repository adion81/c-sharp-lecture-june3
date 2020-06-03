namespace LectureDayThree.Models
{
    public class Bird : Dinosaur
    {
        public bool CanFly;

        public bool HasTeeth = false;
        public Bird(string name, string type, int height,bool canFly) : base(name, type, height, true)
        {
            CanFly = canFly;
            age = 3;
        }

        public override Dinosaur Birthday()
        {
            age += 3;
            System.Console.WriteLine($"{Name} is a bird");
            base.Birthday();
            return this;
        }


    }
}