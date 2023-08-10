namespace ttt
{
    public class Car
    {
        public int Engine_Volume;
        public string model;
        public int passangerCount;
        public string make;
        
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car()
            {
                Engine_Volume = 1,
                model = "X7c5",
                passangerCount = 4,
                make = "BMW",

            };

            Console.WriteLine($"{newCar}");

        }
    }
}