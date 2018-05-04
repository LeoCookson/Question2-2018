using System;

namespace Q222
{
   class Car {
       //Pre set get and set 
        public string Color {get; set;}
        public string Make {get; set;}
        public string Gearbox {get; set;}

// Return what the car is 
        public string DescribeCar() {
            return $"This car is a  {Color} {Make} with a {Gearbox} transmission";
        }

        //User input 
          static void Main(string[] args)
        {
            Console.WriteLine("Enter new car details below:");
            Console.Write("Color: ");
            var color = Console.ReadLine();
            Console.Write("Make: ");
            var make = Console.ReadLine();
            Console.Write("Gearbox: ");
            var gearbox = Console.ReadLine();

            Console.WriteLine();

         //New Vehicle 
            var Vehicle = new Car();
            Vehicle.Make = make;
            Vehicle.Color = color;
            Vehicle.Gearbox = gearbox;
            Console.WriteLine(Vehicle.DescribeCar());

        }
    }
}
  